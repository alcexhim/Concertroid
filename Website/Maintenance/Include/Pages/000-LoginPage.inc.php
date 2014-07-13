<?php
	namespace Objectify\Tenant\Pages;
	
	use WebFX\System;
	
	use WebFX\Controls\Window;
	use WebFX\HorizontalAlignment;
	use WebFX\VerticalAlignment;
	
	use Objectify\Tenant\MasterPages\WebPage;
	use Objectify\Objects\Tenant;
	
	class LoginPage extends WebPage
	{
		public $InvalidCredentials;
		
		public function __construct()
		{
			parent::__construct();
			$this->RenderChrome = false;
		}
		
		protected function RenderContent()
		{
		?>
		<form method="POST">
		<?php
			$wndAuthReq = new Window("wndAuthReq");
			$wndAuthReq->Title = "Authentication Required";
			$wndAuthReq->HorizontalAlignment = HorizontalAlignment::Center;
			$wndAuthReq->VerticalAlignment = VerticalAlignment::Middle;
			$wndAuthReq->BeginContent();
		?>
			<p>You must log in to view this page.</p>
			<table style="margin-left: auto; margin-right: auto;" class="Borderless">
				<tr>
					<td><label for="txtUserName">User <u>N</u>ame</label></td>
					<td><input type="text" name="user_LoginID" id="txtUserName" /></td>
				</tr>
				<tr>
					<td><label for="txtPassword"><u>P</u>assword</label></td>
					<td><input type="password" name="user_Password" id="txtPassword" /></td>
				</tr>
				<tr>
					<td colspan="2" style="color: #FF0000; text-align: center;">
					<?php
						if ($this->InvalidCredentials)
						{
							?>Incorrect user name/password combination.<?php
						}
					?>
					</td>
				</tr>
			</table>
		<?php
			$wndAuthReq->BeginButtons();
		?>
			<input type="submit" value="Continue" />
		<?php
			$wndAuthReq->EndButtons();
			$wndAuthReq->EndContent();
		?>
		</form>
		<?php
		}
	}
?>