<?php
	namespace Concertroid\Online\Pages;
	use System;
	
	class COEntryPointPage extends \Concertroid\Online\COWebPage
	{
		protected function Initialize()
		{
			parent::Initialize();
			$this->CssClass = "SplashScreen";
			$this->HeaderVisible = false;
			$this->FooterVisible = false;
		}
		protected function RenderContent()
		{
?>
<div style="width: 512px; padding-top: 32px; margin-left: auto; margin-right: auto; text-align: center; font-family: Segoe UI; font-weight: lighter; font-size: 16pt; color: #FFFFFF;">
	<h1>Concertroid Online</h1>
	
	<img src="<?php echo(System::ExpandRelativePath("~/images/icons/mainicon.png")); ?>" alt="Concertroid Studio" /><br />
	
	<p>
		Have a Concertroid Online hosted solution? Contact your solution administrator for your login details.
	</p>
</div>
<?php
		}
	}
?>