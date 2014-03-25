<?php
	namespace Concertroid\Online\Pages;
	
	use System;
	use Concertroid\Online\Objects\Client;
	use WebFramework\HorizontalAlignment;
	use WebFramework\Controls\Window;
	
	class COLoginPage extends \Concertroid\Online\COWebPage
	{
		public $PostbackUrl;
		
		protected function Initialize()
		{
			parent::Initialize();
			// $this->CssClass = "SplashScreen";
			$this->PostbackUrl = "~" . $_SERVER["REQUEST_URI"];
			$this->HeaderVisible = false;
			$this->FooterVisible = false;
		}
		protected function RenderContent()
		{
			$client = Client::GetCurrent();
?>
	<noscript>
		Please enable JavaScript to use this Web application.
	</noscript>
<?php
			$window = new Window("wndLoginWindow");
			$window->Title = "Log in to Concertroid Online";
			$window->HorizontalAlignment = HorizontalAlignment::Center;
			$window->Top = 64;
			$window->BeginContent();
			/*
?>
<div style="width: 512px; padding-top: 32px; margin-left: auto; margin-right: auto; text-align: center; font-family: Segoe UI; font-weight: lighter; font-size: 16pt; color: #FFFFFF;">
	<h1>Concertroid Online</h1>
	
	<img src="<?php echo(System::ExpandRelativePath("~/images/icons/mainicon.png")); ?>" alt="Concertroid Studio" /><br />
*/
?>
	<!-- Client ID: <?php echo($client->ID); ?> -->
	<form action="<?php echo(System::ExpandRelativePath($this->PostbackUrl)); ?>" method="POST">
		<table style="width: 400px; border: 0px;">
		<?php
			if (file_exists("images/clients/" . $client->ID . "/login.png"))
			{
		?>
			<tr>
				<td colspan="2"><img style="width: 400px;" src="<?php echo(System::ExpandRelativePath("~/images/clients/" . $client->ID . "/login.png")); ?>" alt="<?php echo($client->Title); ?>" title="<?php echo($client->Title); ?>" /></td>
			</tr>
		<?php
			}
		?>
			<tr>
				<td colspan="2" style="padding-top: 16px; padding-bottom: 16px; text-align: center; font-size: 14pt; font-weight: lighter; color: #00A5A1;"><?php echo($client->Title); ?></td>
			</tr>
			<tr>
				<td><label for="txtUserName">User <u>n</u>ame:</label></td>
				<td><input type="text" id="txtUserName" name="UserName" style="width: 100%;" /></td>
			</tr>
			<tr>
				<td><label for="txtPassword"><u>P</u>assword:</label></td>
				<td><input type="password" id="txtPassword" name="Password" style="width: 100%;" /></td>
			</tr>
			<tr>
				<td colspan="2" style="text-align: center; padding-top: 8px; padding-bottom: 8px;">
				<?php
					if ($_SERVER["REQUEST_METHOD"] == "POST")
					{
				?>
				Invalid user name or password. Please try again.
				<?php
					}
					else
					{
				?>
					&nbsp;
				<?php
					}
				?>
				</td>
			</tr>
			<tr>
				<td colspan="2" style="text-align: right;">
					<input type="submit" value="Log In" />
				</td>
			</tr>
		</table>
	</form>
<?php
	$window->EndContent();
		}
	}
?>