<?php
	include_once("include/system.inc.php");
	include_once("include/account.inc.php");
	
	$website_id = "144FB6EDDC144F7C83F576A0D9F65DB9";
	
	$path = getpath();
	if ($path != null)
	{
		switch ($path[0])
		{
			case "login":
			{
				// $url = "http://connect.alceproject.net/domains/" . $website_id . "/login";
				$url = "/login.php";
				header("Location: " . $url);
				return;
			}
			case "logout":
			{
				// $url = "http://connect.alceproject.net/domains/" . $website_id . "/logout";
				$url = "/login.php?action=logout";
				header("Location: " . $url);
				return;
			}
			case "register":
			{
				// $url = "http://connect.alceproject.net/domains/" . $website_id . "/register";
				$url = "/register.php";
				header("Location: " . $url);
				return;
			}
			case "messages":
			{
				// $url = "http://connect.alceproject.net/domains/" . $website_id . "/messages";
				// header("Location: " . $url);
				page_begin();
?>

<?php
				page_end();
				return;
			}
			default:
			{
				if ($_SESSION["CurrentUserID"] == null)
				{
					header("Location: /account/login");
					return;
				}
			}
		}
	}
	else
	{
		if ($_SESSION["CurrentUserID"] == null)
		{
			header("Location: /account/login");
			return;
		}
		else
		{
			page_begin("Account");
?>

<div class="ButtonContainer ButtonContainerHorizontal">
	<a class="Button" href="messages">
		<img class="ButtonImage" src="http://icons.iconarchive.com/icons/oxygen-icons.org/oxygen/256/Places-mail-message-icon.png" style="width: 64px; height: 64px;" />
		<span class="ButtonTitle">Messages<?php
			$messages = mysql_query("SELECT * FROM cr_messages WHERE message_receiver = " . $UserInfo->ID . " AND message_status = 1;");
			$messageCount = mysql_num_rows($messages);
			if ($messageCount > 0)
			{
				echo(" (" . $messageCount . ")");
			}
		?></span>
	</a>
</div>

<?php
			page_end();
		}
	}
?>