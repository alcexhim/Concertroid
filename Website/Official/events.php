<?php
	include_once("include/system.inc.php");
	
	$path = getpath();
	if ($path != null)
	{
		$query = "SELECT * FROM cr_events";
		if (count($path) > 0)
		{
			$num_id = $path[0];
			if (is_numeric($num_id))
			{
				$query .= " WHERE cre_id = " . $num_id;
			}
			else
			{
				$query .= " WHERE cre_name = '" . mysql_real_escape_string($num_id) . "'";
			}
		}
		
		$result = mysql_query($query);
		if (mysql_num_rows($result) == 1)
		{
			$values = mysql_fetch_assoc($result);
			$num_id = $values["cre_id"];
			if (count($path) > 1)
			{
				if ($path[1] == "images")
				{
					$fileName = "images/events/" . $values["cre_name"] . "/" . $path[2] . ".png";
					if (!file_exists($fileName))
					{
						$fileName = "images/events/unknown.png";
					}
					
					header("Content-Type: " . mime_content_type($fileName));
					readfile($fileName);
					return;
				}
				else if ($path[1] == "stream")
				{
					header("Location: " . $values["cre_stream"]);
					return;
				}
				else if ($path[1] == "setlist")
				{
					header("Content-Type: text/html; charset=UTF-8");
					$hasDownload = false;
					if (count($path) > 1 && $path[2] == "download")
					{
						header("Content-Disposition: attachment; filename=\"" . ($values["cre_title"] . " - Set List") . ".html\"");
						$hasDownload = true;
					}
					
					echo("<!DOCTYPE html>");
					echo("<html>");
					echo("<head>");
					echo("<title>" . $values["cre_title"] . " - Set List</title>");
					echo("<link rel=\"stylesheet\" type=\"text/css\" href=\"/style/cobalt/main.css\" />");
					echo("</head>");
					echo("<body>");
					echo("<table style=\"width: 100%\">");
					
					$songs = mysql_query("SELECT * FROM cr_event_songs WHERE event_id = " . $num_id);
					
					echo("<tr><td><strong>" . $values["cre_title"] . "</strong> - Set List (" . mysql_num_rows($songs) . " songs)</td>");
					if (!$hasDownload)
					{
						echo("<td style=\"width: 100px\">");
						echo("<a href=\"setlist/download\">Download</a>");
						echo("</td>");
					}
					echo("</tr></table>");
					
					/*
						when all else fails, DO THIS.
					include("files/" . $num_id . "/SetList.html");
					return;
					*/
					
					echo("<table style=\"width: 100%; color:#000000\" border=\"1\">");
					echo("<tr style=\"color: #FFFFFF;\">");
					echo("<th style=\"width: 25%\">Performer</th>");
					echo("<th style=\"width: 50%\">Title</th>");
					echo("<th style=\"width: 25%\">Composer</th>");
					echo("</tr>");
					
					$numSongs = mysql_num_rows($songs);
					for ($i = 0; $i < $numSongs; $i++)
					{
						$songs_row = mysql_fetch_assoc($songs);
						
						$song_result = mysql_query("SELECT * FROM cr_songs WHERE song_id = " . $songs_row["song_id"]);
						if (mysql_num_rows($song_result) < 1)
						{
							echo("<tr><td style=\"text-align: center; color: #FF0000;\" colspan=\"3\">NOT FOUND</td></tr>");
						}
						else
						{
							$song_row = mysql_fetch_assoc($song_result);
							echo("<tr");
							
							$color = null;
							$performers = "";
							$song_performer_result = mysql_query("SELECT * FROM cr_song_performers WHERE song_id = " . $songs_row["song_id"]);
							if (mysql_num_rows($song_performer_result) > 0)
							{
								$song_performer_row = mysql_fetch_assoc($song_performer_result);
								
								$performer_result = mysql_query("SELECT * FROM cr_performers WHERE performer_id = " . $song_performer_row["performer_id"]);
								if (mysql_num_rows($performer_result) > 0)
								{
									$performer_row = mysql_fetch_assoc($performer_result);
									if ($i % 2 == 0)
									{
										$color = $performer_row["performer_color"];
									}
									else
									{
										$color = $performer_row["performer_color_alternate"];
									}
									$performers .= $performer_row["performer_name_first"] . " " . $performer_row["performer_name_last"];
								}
								
								for ($j = 1; $j < mysql_num_rows($song_performer_result); $j++)
								{
									$song_performer_row = mysql_fetch_assoc($song_performer_result);
									
									$performer_result = mysql_query("SELECT * FROM cr_performers WHERE performer_id = " . $song_performer_row["performer_id"]);
									if (mysql_num_rows($performer_result) > 0)
									{
										$performer_row = mysql_fetch_assoc($performer_result);
										$performers .= ("; " . $performer_row["performer_name_first"] . ($performer_row["performer_name_last"] == null ? "" : (" " . $performer_row["performer_name_last"])));
									}
								}
							}
							
							if ($color != null)
							{
								echo(" style=\"background-color: " . $color . "\"");
							}
							
							echo(">");
							echo("<td>");
							echo($performers);
							echo("</td>");
							
							echo("<td>");
							echo($song_row["song_title"]);
							echo("</td>");
							
							echo("<td>");
							echo("&nbsp;");
							echo("</td>");
							echo("</tr>");
						}
					}
					
					echo("</table>");
					echo("</body>");
					echo("</html>");
					return;
				}
				else if ($path[1] == "collaborate")
				{
					header("Location: mailto:collab@concertroid.com?subject=" . quoted_printable_encode("Collaboration on " . $values["cre_title"]));
					return;
				}
				else
				{
					header("Location: /events/" . $path[0]);
				}
			}
		}
	}
?>

<?php
	page_begin("events", "Events");
?>
<?php
			function printTable($result)
			{
				$nRows = mysql_num_rows($result);
				
				echo("<table border=\"1\" style=\"width: 100%\">");
				echo("<tr>");
				echo("<th>Title</th>");
				echo("<th>Developer</th>");
				echo("<th>Web site</th>");
				echo("<th>Description</th>");
				echo("<th>Next showtime</th>");
				echo("</tr>");
				for ($i = 0; $i < $nRows; $i++)
				{
					$values = mysql_fetch_assoc($result);
					if ($values["cre_visible"] == 0) continue;
					
					echo("<tr>");
					
					echo("<td><a href=\"/events/" . $values["cre_name"] . "/\">" . $values["cre_title"] . "</a></td>");
					
					$organizers = "";
					$result_organizers = mysql_query("SELECT * FROM cr_event_organizers WHERE event_id = " . $values["cre_id"]);
					$nRowsOrganizers = mysql_num_rows($result_organizers);
					for ($j = 0; $j < $nRowsOrganizers; $j++)
					{
						$organizer_params = mysql_fetch_assoc($result_organizers);
						
						$result_organizer = mysql_query("SELECT * FROM cr_organizers WHERE cro_id = " . $organizer_params["organizer_id"]);
						$organizer_params1 = mysql_fetch_assoc($result_organizer);
						
						$organizers .= "<a href=\"" . $organizer_params1["cro_website"] . "\">" . $organizer_params1["cro_title"] . "</a>";
						if ($j < $nRowsOrganizers - 1) $organizers .= ", ";
					}
					
					
					echo("<td>" . $organizers . "</td>");
					echo("<td><a href=\"" . $values["cre_website"] . "\">" . $values["cre_website"] . "</a></td>");
					echo("<td>" . $values["cre_description"] . "</td>");
					echo("<td>");
					echo($values["cre_date_released"]);
					echo("</td>");
					echo("</tr>");
				}
				echo("</table>");
			}
			
			$query = "SELECT * FROM cr_events";
			if ($num_id != null)
			{
				$query .= " WHERE cre_id = " . $num_id;
			}
			$result = mysql_query($query);
			
			if ($result != null)
			{
				$nRows = mysql_num_rows($result);
				
				if ($path != null)
				{
					if ($nRows == 0)
					{
						echo ("Concert not found");
					}
					else if ($nRows == 1)
					{
					?>
						<span style="font-size: 32pt">concert details</span>
						<p>
						<?php
							$values = mysql_fetch_assoc($result);
						?>
						<table style="width: 100%">
							<tr>
								<td style="width: 100%">
									<?php
										echo("<div style=\"text-align: center;\"><img src=\"/events/" . $path[0] . "/images/banner\" style=\"width: 600px\" alt=\"" . $values["cre_title"] . "\" /></div>");
										echo("<h2>" . $values["cre_title"] . "</h2>");
										echo("<p>" . $values["cre_advert_text"] . "</p>");
										echo("<h3>vital information</h3>");
										echo("<p>");
										echo("<table>");
												$cre_event_organizer_query = "SELECT * FROM cr_event_organizers WHERE event_id = " . $values["cre_id"];
												$cre_event_organizer_result = mysql_query($cre_event_organizer_query);
												$cre_event_organizer_result_count = mysql_num_rows($cre_event_organizer_result);
												if ($cre_event_organizer_result_count > 0)
												{
													for ($i = 0; $i < $cre_event_organizer_result_count; $i++)
													{
														$cre_event_organizer_values = mysql_fetch_assoc($cre_event_organizer_result);
														$cre_organizer_query = "SELECT * FROM cr_organizers WHERE cro_id = " . $cre_event_organizer_values["organizer_id"];
														$cre_organizer_result = mysql_query($cre_organizer_query);
														$cre_organizer_result_count = mysql_num_rows($cre_organizer_result);
														$cre_organizer_values = mysql_fetch_assoc($cre_organizer_result);
														
														if ($cre_organizer_values["cro_website"] != null)
														{
															$cre_organizer .= "<a target=\"_blank\" href=\"" . $cre_organizer_values["cro_website"] . "\">";
														}
														$cre_organizer .= $cre_organizer_values["cro_title"];
														if ($cre_organizer_values["cro_website"] != null)
														{
															$cre_organizer .= "</a>";
														}
														if ($i < $cre_event_organizer_result_count - 1)
														{
															$cre_organizer .= ", ";
														}
													}
													
													echo("<tr>");
														echo("<td>Organized by</td>");
														echo("<td style=\"color: #FFFFFF\">" . $cre_organizer . "</td>");
													echo("</tr>");
												}
											echo("<tr>");
												echo("<td>Next performance</td>");
												echo("<td style=\"color: #FFFFFF\">" . $values["cre_date_open_date"] . "</td>");
											echo("</tr>");
											echo("<tr>");
												echo("<td>OPEN</td>");
												echo("<td style=\"color: #FFFFFF\">" . $values["cre_date_open_time"] . "</td>");
											echo("</tr>");
											echo("<tr>");
												echo("<td>START</td>");
												echo("<td style=\"color: #FFFFFF\">" . $values["cre_date_begin_time"] . "</td>");
											echo("</tr>");
											echo("<tr>");
												echo("<td>END</td>");
												echo("<td style=\"color: #FFFFFF\">" . $values["cre_date_end_time"] . "</td>");
											echo("</tr>");
											
											$cre_location_query = "SELECT * FROM cr_locations WHERE crl_id = " . $values["cre_location_id"];
											$cre_location_result = mysql_query($cre_location_query);
											if (mysql_num_rows($cre_location_result) > 0)
											{
												$cre_location_values = mysql_fetch_assoc($cre_location_result);
												
												$locationText = $cre_location_values["crl_city"] . ", " . $cre_location_values["crl_state"] . ", " . $cre_location_values["crl_country"];
												
												echo("<tr>");
													echo("<td>Location</td>");
													echo("<td style=\"color: #FFFFFF\"><a target=\"_blank\" href=\"https://maps.google.com/maps?q=" . $locationText . "\">" . $locationText . "</a></td>");
												echo("</tr>");
											}
										echo("</table>");
										
										echo("</p>");
										
										echo("<h3>what's happening</h3>");
										echo("<p>" . $values["cre_description"] . "</p>");
										
										if ($values["cre_organizer"] != 9)
										{
											echo("<p style=\"color:#AAFFFF\">This event is NOT affiliated with ALCEproject or Concertroid! Virtual Entertainment.</p>");
										}
									?>
								</td>
								<td style="vertical-align: top;">
									<ul>
										<?php
										if ($values["cre_stream"] == null) // use === ?
										{?>
											<li title="Live stream doesn't exist"><a href="#"><img src="/images/icons/watch.png" alt="Watch" /> <span class="ButtonText">Watch</span> <span class="ButtonDescription">live on ustream.tv</span></a></li>
										<?php
										}
										else
										{?>
											<li><a href="<?php echo("/events/" . $path[0] . "/stream") ?>" target="_blank"><img src="/images/icons/watch.png" alt="Watch" /> <span class="ButtonText">Watch</span> <span class="ButtonDescription">live on ustream.tv</span></a></li>
										<?php
										}
										
										$songCount = mysql_num_rows(mysql_query("SELECT * FROM cr_event_songs WHERE event_id = " . $num_id));
										if ($songCount < 1)
										{?>
											<li title="Set list doesn't exist"><a href="#"><img src="/images/icons/list.png"alt="View" /> <span class="ButtonText">View</span> <span class="ButtonDescription">the list of songs</span></a></li>
										<?php
										}
										else
										{
										?>
											<li title="Set list doesn't exist"><a href="/events/<?php echo($path[0]) ?>/setlist" target="_blank"><img src="/images/icons/list.png"alt="View" /> <span class="ButtonText">View</span> <span class="ButtonDescription">the list of songs</span></a></li>
										<?php
										}
										?>
									</ul>
								</td>
							</tr>
						</table>
						</p>
					<?php
					}
				}
				else
				{
				?>
				<h3>Experience the symbiosis of music and technology</h3>
				<p>
					Following the VOCALOID concerts that have been presented by <a href="http://www.crypton.co.jp/">Crypton Future Media</a> in Japan
					every year since 2009, talented artists, musicians, software developers, and fans from around the world showed their appreciation
					by spawning a movement that was previously unheard of: concerts that are put on by fans, for fans, collaborating no matter where
					they are through the information superhighway that is the Internet. <a href="/login.php">Log in</a>
					to add or make changes to your own event!
				</p>
				<p>
					<?php
						printTable($result);
					?>
				</p>
				<?php
				}
			}
			
			mysql_close();
?>
<?php
	page_end();
?>