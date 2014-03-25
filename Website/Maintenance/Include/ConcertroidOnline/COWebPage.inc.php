<?php
	namespace Concertroid\Online;
	
	use WebFramework\WebStyleSheet;
	use WebFramework\Controls\Menu;
	use WebFramework\Controls\MenuItemCommand;
	use WebFramework\Controls\Window;
	
	use Concertroid\Online\Controls\COHeaderControl;
	
	class COWebPage extends \WebFramework\WebPage
	{
		public $HeaderVisible;
		public $FooterVisible;
		
		public function __construct()
		{
			$this->ContextMenu = new Menu("mnuContext");
			$this->ContextMenu->MenuItems = array
			(
				new MenuItemCommand("About Concertroid Online"),
				new MenuItemCommand("About WebFX")
			);
		}
		
		protected function Initialize()
		{
			parent::Initialize();
			$this->StyleSheets[] = new WebStyleSheet("~/StyleSheets/Main.css");
			$this->HeaderVisible = true;
			$this->FooterVisible = true;
		}
		
		protected function BeforeContent()
		{
			if ($this->HeaderVisible)
			{
				$header = new COHeaderControl("hdrPageHeader");
				$header->Render();
			}
			
			$dlgAbout = new Window("dlgAbout");
			$dlgAbout->Visible = false;
			$dlgAbout->Title = "About Concertroid Online";
			$dlgAbout->BeginContent();
?>
<div style="text-align: center;">
	<img src="<?php echo(\System::ExpandRelativePath("~/images/icons/mainicon.png")); ?>" />
</div>
<div style="text-align: left;">
Concertroid Online version 1.0e3<br />
Copyright &copy;2013 Concertroid! Virtual Entertainment<br />
DEVELOPMENT SERVER
</div>
<div style="text-align: center;">
	<input type="button" onclick="dlgAbout.Hide();" value="OK" />
</div>
<?php
			$dlgAbout->EndContent();
		}
		protected function AfterContent()
		{
			if ($this->FooterVisible)
			{
?>
				<div class="Footer">
					Concertroid Online version 1.0e3 &bullet; Copyright &copy;2013 Concertroid! Virtual Entertainment &bullet; DEVELOPMENT SERVER
				</div>
<?php
			}
		}
	}
?>