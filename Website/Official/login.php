<!DOCTYPE html>
<?php	
	include_once("include/system.inc.php");
	
	if ($_GET["action"] == "logout")
	{
		$_SESSION["CurrentUserID"] = null;
		header("Location: /");
		return;
	}
	
	$UserLoginError = 0;
	if ($_POST["un"] != "" && $_POST["pw"] != "")
	{
		// attempt to log in the user
		$result = mysql_query("SELECT * FROM cr_users WHERE user_username = '" . mysql_real_escape_string($_POST["un"]) . "' AND user_password = '" . mysql_real_escape_string($_POST["pw"]) . "';");
		if (mysql_num_rows($result) == 1)
		{
			$values = mysql_fetch_assoc($result);
			if ($values["user_emailcode"] != null)
			{
				$UserLoginError = 5;
			}
			else if ($values["user_activatecode"] != null)
			{
				$UserLoginError = 6;
			}
			else
			{
				$_SESSION["CurrentUserID"] = $values["user_id"];
				
				header("Location: /account");
				return;
			}
		}
		else
		{
			$UserLoginError = 1;
		}
	}
	else if ($_POST["un"] != "")
	{
		$UserLoginError = 2; // BLANK_PW
	}
	else if ($_POST["pw"] != "")
	{
		$UserLoginError = 3; // BLANK_UN
	}
	else if ($_POST["un"] == "" && $_POST["pw"] == "")
	{
		$UserLoginError = 4; // BLANK_UN_AND_PW
	}
?>
<?php page_begin(); ?>
<h3>You are not logged in</h3>
<p>
	Welcome to the Concertroid! community member login page. If you already
	have an account, you may log in by the form below. If you are not yet a member, you may
	<a href="register.php">request an account</a>.
</p>
<p>
	<form id="frmLogin" method="POST" action="login.php">
		<table style="margin-left: auto; margin-right: auto;">
			<tr>
				<td>User <u>n</u>ame:</td>
				<td><input name="un" type="text" accesskey="n" size="50" maxlength="50" value="<?php echo($_POST["un"]) ?>" /></td>
			</tr>
			<tr>
				<td><u>P</u>assword:</td>
				<td><input name="pw" type="password" accesskey="P" size="50" maxlength="50" /></td>
			</tr>
			<tr>
				<td colspan="2" style="text-align: right;"><input type="submit" value="Log In" /> <a class="Button" href="/">Cancel</a></td>
			</tr>
		</table>
	</form>
</p>
<?php
if ($UserLoginError == 1)
{
	echo("<p>The user name and/or password you provided is invalid. Please try again.</p>");
}
else if ($UserLoginError == 2) // BLANK_PW
{
	echo("<p>Please enter a password.</p>");
}
else if ($UserLoginError == 3) // BLANK_UN
{
	echo("<p>Please enter a user name.</p>");
}
else if ($UserLoginError == 4) // BLANK_UN_AND_PW
{
	echo("<p>Please enter a user name and password.</p>");
}
else if ($UserLoginError == 5) // EMAIL_CODE
{
	echo("<p>Your account has been registered, but requires e-mail confirmation. Please click on the link in the confirmation e-mail to complete registration. If you did not receive a confirmation e-mail, you can <a href=\"register.php?action=SendActivationEmail&uid=" . $uid . ">request another</a>.</p>");
}
else if ($UserLoginError == 6) // ACTIVATE_CODE
{
	echo("<p>Your request for membership has been received, but is awaiting approval. If you do not receive approval within the coming week, you can <a href=\"mailto:registration@concertroid.com\">send us an e-mail</a> to inquire about it.</p>");
}

page_end();
?>