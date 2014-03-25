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
				if ($path[1] == "stream")
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
					
					echo("<html>");
					echo("<head>");
					echo("<title>" . $values["cre_title"] . " - Set List</title>");
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
					
					echo("<table style=\"width: 100%\" border=\"1\">");
					echo("<tr>");
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
					header("Location: /c/" . $path[0]);
				}
			}
		}
	}
?>

<?php
	page_begin("events", "Concerts and Events");
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
					
					echo("<td><a href=\"/c/" . $values["cre_id"] . "/\">" . $values["cre_title"] . "</a></td>");
					
					$organizers = "";
					$result_organizers = mysql_query("SELECT * FROM cr_event_organizers WHERE event_id = " . $values["cre_id"]);
					$nRowsOrganizers = mysql_num_rows($result_organizers);
					for ($j = 0; $j < $nRowsOrganizers; $j++)
					{
						$organizer_params = mysql_fetch_assoc($result_organizers);
						$result_organizer = mysql_query("SELECT * FROM cr_organizers WHERE cro_id = " . $organizer_params["organizer_id"]);
						$organizers .= "<a href=\"" . $result_organizer["cro_website"] . "\">" . $result_organizer["cro_title"] . "</a>";
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
		?>
			<?php
			$query = "SELECT * FROM cr_events";
			if ($num_id != null)
			{
				$query .= " WHERE cre_id = " . $num_id;
			}
			$result = mysql_query($query);
			
			if ($result != null)
			{
				$nRows = mysql_num_rows($result);
				if ($_GET["id"] != null)
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
										echo("Concert title: <span style=\"color: #FFFFFF\">" . $values["cre_title"] . "</span><br />");
										echo("Next performance: <span style=\"color: #FFFFFF\">" . $values["cre_performance_date"] . "</span><br />");
									?>
								</td>
								<td style="vertical-align: top;">
									<?php
									if ($values["cre_stream"] == null) // use === ?
									{?>
									<span class="Button BigButton ButtonDisabled" title="Live stream doesn't exist">
										<table>
											<tr>
												<td rowspan="2">
													<img src="/images/icons/watch.png" alt="Watch" />
												</td>
												<td class="ButtonText">Watch</td>
											</tr>
											<tr>
												<td class="ButtonDescription">live on ustream.tv</td>
											</tr>
										</table>
									</span>
									<?php
									}
									else
									{?>
									<a href="<?php echo("/c/" . $path[0] . "/stream") ?>" class="Button BigButton" target="_blank">
										<table>
											<tr>
												<td rowspan="2">
													<img src="/images/icons/watch.png" alt="Watch" />
												</td>
												<td class="ButtonText">Watch</td>
											</tr>
											<tr>
												<td class="ButtonDescription">live on ustream.tv</td>
											</tr>
										</table>
									</a><?php
									}
									?>
								</td>
								<td style="vertical-align: top">
									<?php
									$songCount = mysql_num_rows(mysql_query("SELECT * FROM cr_event_songs WHERE event_id = " . $num_id));
									if ($songCount < 1)
									{?>
									<span class="Button BigButton ButtonDisabled" title="Set list doesn't exist">
										<table>
											<tr>
												<td rowspan="2">
													<img src="/images/icons/list.png" alt="View" />
												</td>
												<td class="ButtonText">View</td>
											</tr>
											<tr>
												<td class="ButtonDescription">the list of songs</td>
											</tr>
										</table>
									</span>
									<?php
									}
									else
									{
									?>
									<a href="/c/<?php echo($path[0]) ?>/setlist" class="Button BigButton" target="_blank">
										<table>
											<tr>
												<td rowspan="2">
													<img src="/images/icons/list.png" alt="View" />
												</td>
												<td class="ButtonText">View</td>
											</tr>
											<tr>
												<td class="ButtonDescription">the list of songs</td>
											</tr>
										</table>
									</a><?php
									}
									?>
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
				<span class="BigHeaderText">experience the symbiosis <span class="BigHeaderTextAlternate">of music and technology</span></span>
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