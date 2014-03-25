<?php
	global $num_id;
	global $UserInfo;
	
	include_once("include/system.inc.php");
	
	function SendMessage($message_sender, $message_receiver, $message_subject, $message_content, $message_timestamp = null, $message_status = true)
	{
		mysql_query("INSERT INTO cr_messages (message_sender, message_receiver, message_subject, message_content, message_timestamp, message_status) VALUES (" .
		"'" . mysql_real_escape_string($message_sender) . "', " .
		"'" . mysql_real_escape_string($message_receiver) . "', " .
		"'" . mysql_real_escape_string($message_subject) . "', " .
		"'" . mysql_real_escape_string($message_content) . "', " .
		($message_timestamp == null ? "'" . date("Ymd") . "'" : "'" . mysql_real_escape_string($message_timestamp) . "'") . ", " .
		($message_status ? "1" : "0") .
		");");
		
		if (mysql_errno() != 0)
		{
			return false;
		}
		return true;
	}
	
	$path = getpath();
	
	if ($path == null)
	{
		$result = mysql_query("SELECT * FROM cr_users WHERE " . ($_GET["ShowDisabledUsers"] == "1" ? "" : "user_enabled = 1 AND ") . " user_visible = 1");
	}
	else
	{
		$result = mysql_query("SELECT * FROM cr_users WHERE user_id = " . $path[0]);
		if (count($path) > 1)
		{
			if ($path[1] == "messages" && count($path) > 2)
			{
				$messageID = $path[2];
				if ($messageID == "send")
				{
					// get the receiver's user ID
					$recv = $_POST["recv"];
					
					$recvIDQuery = mysql_query("SELECT * FROM cr_users WHERE user_displayname = '" . $recv . "';");
					$recvIDResult = mysql_fetch_assoc($recvIDQuery);
					
					$recvID = $recvIDResult["user_id"];
					
					if (!SendMessage($_SESSION["CurrentUserID"], $recvID, $_POST["subj"], $_POST["content"]))
					{
						echo(mysql_error());
						return;
					}
					
					header("Location: /members/" . $path[0]);
					return;
				}
			}
			else if ($path[1] == "messages")
			{
				if ($_SESSION["CurrentUserID"] != "1" && ($path[0] != $_SESSION["CurrentUserID"]))
				{
					// Not authorized to view other people's messages.
					header("Location: /members/" . $path[0]);
					return;
				}
			}
		}
	}
	
	function printTable($result)
	{
		mysql_data_seek($result, 0);
		$nRows = mysql_num_rows($result);
		
		echo("<table border=\"1\" style=\"width: 100%\">");
		echo("<tr>");
		echo("<th>Display name</th>");
		echo("<th>Capabilities</th>");
		echo("</tr>");
		for ($i = 0; $i < $nRows; $i++)
		{
			$values = mysql_fetch_assoc($result);
			echo("<tr>");
			
			echo("<td><a href=\"/members/" . $values["user_id"] . "/\">" . $values["user_displayname"] . "</a></td>");
			
			echo("<td>");
			
			// var_dump($values);
			
			echo("</td>");
			
			echo("</tr>");
		}
		echo("</table>");
	}
?>
<?php
	page_begin();
	
	if ($result != null)
	{
		$nRows = mysql_num_rows($result);
		if ($path != null)
		{
			if ($nRows == 0)
			{
				echo ("Member not found");
			}
			else if ($nRows == 1)
			{
				if ($path[1] == "messages" && count($path) == 2)
				{
					$messages = mysql_query("SELECT * FROM cr_messages WHERE message_receiver = " . $path[0] . ";");
					$messageCount = mysql_num_rows($messages);
				
					// BEGIN: Message Header Table
					echo("<table style=\"width: 100%\">");
					echo("<tr>");
					
					// BEGIN: New Message Notification
					echo("<td>");
					if ($messageCount == 0)
					{
						echo("You have no new messages.");
					}
					else if ($messageCount == 1)
					{
						echo("You have 1 new message.");
					}
					else if ($messageCount > 1)
					{
						echo("You have " . $messageCount . " messages.");
					}
					echo("</td>");
					// END: New Message Notification
					
					// BEGIN: Message Action Toolbar
					echo("<td style=\"text-align: right;\">");
					echo("<a href=\"/members/" . $path[0] . "/messages/new/\">New Message</a>");
					echo("</td>");
					// END: Message Action Toolbar
					
					echo("</tr>");
					echo("</table>");
					// END: Message Header Table
					
					if ($messageCount > 0)
					{
						// BEGIN: Message List Table
						echo("<table border=\"1\" style=\"width: 100%\">");
						echo("<tr>");
						echo("<th>From</th>");
						echo("<th>Subject</th>");
						echo("<th>Date Sent</th>");
						echo("</tr>");
						for ($i = 0; $i < $messageCount; $i++)
						{
							$values = mysql_fetch_assoc($messages);
							echo("<tr>");
							
							$senderRequest = mysql_query("SELECT * FROM cr_users WHERE user_id = " . $values["message_sender"]);
							$senderData = mysql_fetch_assoc($senderRequest);
							
							echo("<td");
							if ($values["message_status"] == 1)
							{
								echo(" style=\"font-weight: bold;\"");
							}
							echo("><a href=\"/members/" . $senderData["user_id"] . "\">" . $senderData["user_displayname"] . "</a></td>");
							echo("<td");
							if ($values["message_status"] == 1)
							{
								echo(" style=\"font-weight: bold;\"");
							}
							echo("><a href=\"/members/" . $path[0] . "/messages/" . $values["message_id"] . "\">" . $values["message_subject"] . "</a></td>");
							echo("<td");
							if ($values["message_status"] == 1)
							{
								echo(" style=\"font-weight: bold;\"");
							}
							echo(">" . $values["message_timestamp"] . "</td>");
							echo("</tr>");
						}
						echo("</table>");
						// END: Message List Table
					}
				}
				else if ($path[1] == "messages" && count($path) > 2)
				{
					$messageID = $path[2];
					if ($messageID == "new")
					{
						echo("<form action=\"/members/" . $path[0] . "/messages/send\" method=\"POST\">");
						echo("<table style=\"width: 100%\">");
						echo("<tr>");
						echo("<td style=\"width: 64px\">");
						echo("</td>");
						echo("<td><input type=\"text\" name=\"recv\" /></td>");
						echo("</tr>");
						echo("<tr>");
						echo("<td colspan=\"3\" style=\"font-weight: bold;\">");
						echo("<input type=\"text\" name=\"subj\" />");
						echo("</td>");
						echo("</tr>");
						echo("<tr>");
						echo("<td colspan=\"3\">");
						echo("<textarea name=\"content\"></textarea>");
						echo("</td>");
						echo("</tr>");
						echo("<tr>");
						echo("<td colspan=\"3\" style=\"text-align: right\">");
						echo("<input type=\"submit\" value=\"Send\" />");
						echo("<input type=\"reset\" value=\"Clear\" />");
						echo("</td>");
						echo("</tr>");
						echo("</table>");
						echo("</form>");
					}
					else
					{
						$message = mysql_query("SELECT * FROM cr_messages WHERE message_receiver = " . $UserInfo->ID . " AND message_id = " . $messageID . ";");
						if (mysql_num_rows($message) == 0)
						{
							echo ("Message not found: " . $messageID);
							return;
						}
						
						$messageData = mysql_fetch_assoc($message);
						
						// Mark the message read
						mysql_query("UPDATE cr_messages SET message_status = 0 WHERE message_receiver = " . $UserInfo->ID . " AND message_id = " . $messageData["message_id"]);
						
						$senderQuery = mysql_query("SELECT * FROM cr_users WHERE user_id = " . $messageData["message_sender"]);
						$senderData = mysql_fetch_assoc($senderQuery);
						
						?>
						
						<table style="width: 100%">
							<tr>
								<td style="width: 64px"></td>
								<td><?php echo("<a href=\"/members/" . $senderData["user_id"] . "\">" . $senderData["user_displayname"] . "</a>"); ?></td>
								<td style="text-align: right;">
									<a href="#">Reply</a> | <a href="#">Forward</a> | <a href="#">Delete</a>
								</td>
							</tr>
							<tr>
								<td colspan="3" style="font-weight: bold;">
									<?php echo($messageData["message_subject"]); ?>
								</td>
							</tr>
							<tr>
								<td colspan="3">
									<?php echo($messageData["message_content"]); ?>
								</td>
							</tr>
						</table>
						
						<?php
					}
				}
				else
				{
					$values = mysql_fetch_assoc($result);
					
					$creatable = false;
					$editable = ($_SESSION["CurrentUserID"] == $values["user_id"]);
					
					?>
					<span class="BigHeaderText">member details <span class="BigHeaderTextAlternate"><?php echo($values["user_displayname"]); ?></span>
					<table style="width: 100%">
						<tr>
							<td colspan="2" style="text-align: right;">
							<?php if ($editable) { ?><a href="#">Edit Information</a><?php } ?>
							</td>
						</tr>
					</table>
					<?php
				}
			}
		}
		else
		{
		?>
		<span class="BigHeaderText">get involved in the community</span>
		<p>
			
		</p>
		<p>
			<?php
				printTable($result);
			?>
		</p>
		<?php
		}
	}
	
	page_end();
?>