<!DOCTYPE html>
<?php
	include_once("include/system.inc.php");
	include_once("include/account.inc.php");
	
	if ($_GET["c"] != null)
	{
		$code = $_GET["c"];
		
		$user_emailcode = mysql_real_escape_string($_GET["c"]);
		$result = mysql_query("SELECT * FROM cr_users WHERE user_emailcode = '" . $user_emailcode . "'");
		if (mysql_num_rows($result) == 1)
		{
			// enable the user
			$data = mysql_fetch_assoc($result);
			mysql_query("UPDATE cr_users SET user_emailcode = NULL WHERE user_emailcode = '" . $user_emailcode . "'");
			
			SendMessage($data["user_id"], 1, "Membership Request", "<p>This person would like to become a member.</p><table><tr><td>Full name:</td><td>" . $data["user_fullname"] . "</td></tr><tr><td>Comments:</td><td>" . $data["user_comments"] . "</td></tr></table><p><a href=\"/register.php?approve=" . $data["user_activatecode"] . "\">Approve</a> or <a href=\"/register.php?reject=" . $data["user_activatecode"] . "\">reject</a> the request.</p>", date("Ymd"));
			$UserRegistered = 2;
		}
		else
		{
			$UserRegistered = 4;
		}
	}
	else if ($_GET["approve"] != null)
	{
		$result = mysql_query("SELECT * FROM cr_users WHERE user_activatecode = '" . mysql_real_escape_string($_GET["approve"]) . "'");
		if (mysql_num_rows($result) == 1)
		{
			// enable the user
			$data = mysql_fetch_assoc($result);
			$UserDisplayName = $data["user_displayname"];
			
			mysql_query("UPDATE cr_users SET user_enabled = 1, user_activatecode = NULL WHERE user_activatecode = '" . mysql_real_escape_string($_GET["approve"]) . "'");
			
			mail($data["user_email"], "Your registration for Concertroid! has been approved", "<html><body><p>Hello, " . $data["user_fullname"] . ".</p><p>Your request to become a member has been approved. We hope you enjoy being part of the Concertroid! community.</p></body></html>", "From: registration@concertroid.com\r\nContent-type: text/html; charset=iso-8859-1");
			
			$UserRegistered = 5;
		}
		else
		{
			$UserRegistered = 4;
		}
	}
	else if ($_GET["reject"] != null)
	{
		$query = "SELECT * FROM cr_users WHERE user_activatecode = '" . mysql_real_escape_string($_GET["reject"]) . "'";
		$result = mysql_query($query);
		if (mysql_num_rows($result) == 1)
		{
			// kick out the user
			$data = mysql_fetch_assoc($result);
			$UserDisplayName = $data["user_displayname"];
			
			mysql_query("DELETE FROM cr_users WHERE user_activatecode = '" . mysql_real_escape_string($_GET["reject"]) . "'");
			$UserRegistered = 6;
		}
		else
		{
			$UserRegistered = 4;
		}
	}
	else if ($_POST["un"] != null && $_POST["pw"] != null && $_POST["dn"] != null && $_POST["fn"] != null && $_POST["em"] != null)
	{
		// Add the new entry for this user in the database
		if (!RegisterUser($_POST["un"], $_POST["pw"], $_POST["dn"], $_POST["fn"], $_POST["em"], $_POST["cmnt"]))
		{
			$UserRegistered = 3;
		}
		else
		{
			$UserRegistered = 1;
		}
	}
	else
	{
		$UserRegistered = 0;
	}
	
	page_begin();
	
	if ($UserRegistered == 0)
	{
	?>
	<p>
		Thank you for your interest in becoming a member of the Concertroid! community. Please fill out
		all the required details and submit the form below. A representative from the community will review
		your membership request and contact you when the request is approved.
	</p>
	<p>
		<form id="frmLogin" method="POST" action="register.php">
			<table style="width: 100%">
				<tr>
					<td><?php if ($_POST["un"] !== null && $_POST["un"] == "") echo("<span style=\"color: #FF0000\">*</span> "); ?> User <u>n</u>ame (private):</td>
					<td><input name="un" type="text" accesskey="n" size="50" maxlength="50" value="<?php echo($_POST["un"]) ?>" /></td>
				</tr>
				<tr>
					<td><?php if ($_POST["pw"] !== null && $_POST["pw"] == "") echo("<span style=\"color: #FF0000\">*</span> "); ?> <u>P</u>assword:</td>
					<td><input name="pw" type="password" accesskey="P" size="50" maxlength="50" /></td>
				</tr>
				<tr>
					<td><?php if ($_POST["dn"] !== null && $_POST["dn"] == "") echo("<span style=\"color: #FF0000\">*</span> "); ?> <u>D</u>isplay name (public):</td>
					<td><input name="dn" type="text" accesskey="D" size="50" maxlength="50" value="<?php echo($_POST["dn"]) ?>" /></td>
				</tr>
				<tr>
					<td><?php if ($_POST["fn"] !== null && $_POST["fn"] == "") echo("<span style=\"color: #FF0000\">*</span> "); ?> <u>F</u>ull name (private):</td>
					<td><input name="fn" type="text" accesskey="F" size="50" maxlength="50" value="<?php echo($_POST["fn"]) ?>" /></td>
				</tr>
				<tr>
					<td><?php if ($_POST["em"] !== null && $_POST["em"] == "") echo("<span style=\"color: #FF0000\">*</span> "); ?> <u>E</u>-mail address (private):</td>
					<td><input name="em" type="text" accesskey="E" size="50" maxlength="50" value="<?php echo($_POST["fn"]) ?>" /></td>
				</tr>
				<tr>
					<td style="vertical-align: top"><u>A</u>rea of expertise (check all that apply):</td>
					<td>
						<table style="border: solid 1px #00FF00;">
							<tr>
							<?php
							$capabilitiesQuery = mysql_query("SELECT * FROM cr_capabilities");
							$capabilitiesCount = mysql_num_rows($capabilitiesQuery);
							for ($i = 0; $i < $capabilitiesCount; $i++)
							{
								$capabilitiesResult = mysql_fetch_assoc($capabilitiesQuery);
								
								echo("<td><input type=\"checkbox\" name=\"exp" . $capabilitiesResult["capability_id"] . "\" id=\"chkExpertise" . $capabilitiesResult["capability_id"] . "\"><label for=\"chkExpertise" . $capabilitiesResult["capability_id"] . "\">" . $capabilitiesResult["capability_title"] . "</label></td>");
								
								if ((($i + 1) % 2) == 0)
								{
									echo("</tr><tr>");
								}
							}
							?>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td style="vertical-align: top">Other comments:</td>
					<td>
						<textarea name="cmnt" cols="50" rows="3"></textarea>
					</td>
				</tr>
				<tr>
					<td colspan="2" style="color: #FFFFFF; padding-top: 16px;">
					<?php
						if (
						($_POST["un"] !== null && $_POST["un"] == "") ||
						($_POST["pw"] !== null && $_POST["pw"] == "") ||
						($_POST["dn"] !== null && $_POST["dn"] == "") ||
						($_POST["fn"] !== null && $_POST["fn"] == "") ||
						($_POST["em"] !== null && $_POST["em"] == "")
						)
						{
							echo("Your request for membership could not be completed because some required information was not provided. Please ensure that all fields marked with a red asterisk (<span style=\"color: #FF0000\">*</span>) have been completely filled out.");
						}
					?> 
					</td>
				</tr>
				<tr>
					<td colspan="2" style="padding-top: 16px; text-align: right;">
						<div style="border-top: solid 1px #00FF00; padding-top: 16px">
							<input type="submit" value="Register" /> <a class="Button" href="/">Cancel</a>
						</div>
					</td>
				</tr>
			</table>
		</form>
	</p>
	<?php
	}
	else if ($UserRegistered == 1)
	{
	?>
	<p>
		Thank you for your interest in becoming a member of the Concertroid! community. Before your request can be processed, you must verify your e-mail address. A verification
		e-mail has been sent to <strong><?php echo($_POST["em"]) ?></strong>. Please click on the link in the verification e-mail to complete your registration.
	</p>
	<p style="text-align: center;">
		<a href="/">Return to Home Page</a>
	</p>
	<?php
	}
	else if ($UserRegistered == 2)
	{
	?>
	<p>
		Thank you for your interest in becoming a member of the Concertroid! community. Your request has been received, and you will be notified when it has been processed.
		Once your request has been approved, you may log in to the Concertroid! community Web site.
	</p>
	<p style="text-align: center;">
		<a href="/">Return to Home Page</a>
	</p>
	<?php
	}
	else if ($UserRegistered == 3)
	{
	?>
	<p>
		Thank you for your interest in becoming a member of the Concertroid! community. Unfortunately, an error has occurred while attempting to process your request. You
		can try refreshing the page, or (better yet) clicking the &quot;Log In/Register&quot; link again and filling out the form manually. If this continues to happen,
		please <a href="mailto:webmaster@concertroid.com">e-mail the administrator</a> and explain the issue you are having.
	</p>
	<p>
		<?php echo(mysql_errno() . " : " . mysql_error()); ?>
	</p>
	<p style="text-align: center;">
		<a href="/">Return to Home Page</a>
	</p>
	<?php
	}
	else if ($UserRegistered == 4)
	{
	?>
	<p>
		The user verification code that you have provided is invalid. Your session may have expired, or an internal error may have occurred. You can try clicking the 
		&quot;Log In/Register&quot; link and filling out the registration form again. If this continues to happen, please <a href="mailto:webmaster@concertroid.com">e-mail
		the administrator</a> and explain the issue you are having.
	</p>
	<p style="text-align: center;">
		<a href="/">Return to Home Page</a>
	</p>
<?php
	}
	else if ($UserRegistered == 5)			// USER_APPROVED
	{
?>
	<p>
		You have approved <?php echo($UserDisplayName) ?>'s request to join the community.
	</p>
	<p style="text-align: center;">
		<a href="/">Return to Home Page</a>
	</p>
<?php
	}
	else if ($UserRegistered == 6)			// USER_REJECTED
	{
?>
	<p>
		You have rejected <?php echo($UserDisplayName) ?>'s request to join the community.
	</p>
	<p style="text-align: center;">
		<a href="/">Return to Home Page</a>
	</p>
<?php
	}
	page_end();
?>