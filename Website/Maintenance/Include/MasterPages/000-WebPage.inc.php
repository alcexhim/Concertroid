<?php
	namespace Objectify\Tenant\MasterPages;
	
	use WebFX\WebStyleSheet;
	use WebFX\System;
	
	use WebFX\Controls\Ribbon;
	use WebFX\Controls\RibbonTab;
	use WebFX\Controls\RibbonTabGroup;
	use WebFX\Controls\RibbonButtonCommand;
	use WebFX\Controls\RibbonDropDownCommand;
	use WebFX\Controls\RibbonCommandReferenceItem;
	
	use WebFX\Controls\SplitContainer;
	
	use WebFX\Controls\Window;
	
	use WebFX\Controls\Wunderbar;
	use WebFX\Controls\WunderbarPanel;
	
	class WebPage extends \WebFX\WebPage
	{
		public function __construct()
		{
			parent::__construct();
			
			$this->StyleSheets[] = new WebStyleSheet("http://static.alcehosting.net/dropins/WebFramework/StyleSheets/Workday/Main.css");
			$this->StyleSheets[] = new WebStyleSheet("http://static.alcehosting.net/dropins/WebFramework/StyleSheets/Office2010/Main.css");
			$this->RenderChrome = true;
			
			$this->scLeftRight = new SplitContainer();
			$this->scLeftRight->SplitterPosition = "180px";
		}
		
		public $RenderChrome;
		
		private $scLeftRight;
		
		protected function BeforeContent()
		{
			$wndGenericMessage = new Window("wndGenericMessage");
			$wndGenericMessage->Visible = false;
			$wndGenericMessage->Title = "Information";
			$wndGenericMessage->BeginContent();
			echo("This is a test of the MessageBox functionality.");
			$wndGenericMessage->BeginButtons();
			echo("<input type=\"button\" onclick\"wndGenericMessage.Close();\" value=\"OK\" />");
			$wndGenericMessage->EndButtons();
			$wndGenericMessage->EndContent();
		
			if ($this->RenderChrome)
			{
				$ribbon = new Ribbon("ribbon");
				$ribbon->Title = "Concertroid Online";
				if (System::$TenantName == "system")
				{
					$ribbon->Title .= " [Administrator]";
				}
				$this->Title = "Concertroid Online";
				
				// common ribbon content
				$ribbon->Commands[] = new RibbonButtonCommand("cmdLogOut", "Sign Out", "~/account/logout.page", null, "~/images/ribbon/logout.png");
				
				$tabHome = new RibbonTab("tabHome", "Home");
				$ribbon->SelectedTab = $tabHome;
				$ribbon->Tabs[] = $tabHome;
				
				if (System::$TenantName == "system")
				{
					// tenant manager-specific ribbon content
					$ribbon->Commands[] = new RibbonButtonCommand("cmdTenantClone", "Clone from Existing", "~/tenant/clone", null, "~/images/ribbon/tenant/clone.png");
				
					$tabTenant = new RibbonTab("tabTenant", "Tenant");
					$grpCreate = new RibbonTabGroup("grpCreate", "Create");
					$grpCreate->Items[] = new RibbonCommandReferenceItem("cmdTenantClone");
					$tabTenant->Groups[] = $grpCreate;
					$ribbon->Tabs[] = $tabTenant;
				}
				else
				{
					// application-specific ribbon content
					$ribbon->Commands[] = new RibbonButtonCommand("cmdCreateNewSimpleSetlist", "Simple Setlist (Express)");
					$ribbon->Commands[] = new RibbonButtonCommand("cmdCreateNewAdvancedSetlist", "Advanced Setlist (Script)");
					$ribbon->Commands[] = new RibbonButtonCommand("cmdCreateNewAutoSetlist", "Build Setlist from Songs");
					
					$cmdCreateNew = new RibbonDropDownCommand("cmdCreateNew", "New Setlist");
					
					$cmdCreateNew->Items[] = new RibbonCommandReferenceItem("cmdCreateNewSimpleSetlist");
					$cmdCreateNew->Items[] = new RibbonCommandReferenceItem("cmdCreateNewAdvancedSetlist");
					$cmdCreateNew->Items[] = new RibbonCommandReferenceItem("cmdCreateNewAutoSetlist");
					
					$ribbon->Commands[] = $cmdCreateNew;
					$ribbon->Commands[] = new RibbonButtonCommand("cmdCreateFromExisting", "From Existing...");
					
					$ribbon->Commands[] = new RibbonButtonCommand("cmdCreateSong", "Song");
					$ribbon->Commands[] = new RibbonButtonCommand("cmdCreateCharacter", "Character");
					
					$grpCreate = new RibbonTabGroup("grpMainCreate", "Create");
					$grpCreate->Items[] = new RibbonCommandReferenceItem("cmdCreateNew");
					$grpCreate->Items[] = new RibbonCommandReferenceItem("cmdCreateFromExisting");
					$tabHome->Groups[] = $grpCreate;
					
					$tabLibrary = new RibbonTab("tabLibrary", "Library");
					$grpCreate = new RibbonTabGroup("grpLibraryCreate", "Create");
					
					$ribbon->Commands[] = new RibbonButtonCommand("cmdLibraryCreateNewAnimation", "Animation");
					$ribbon->Commands[] = new RibbonButtonCommand("cmdLibraryCreateNewCharacter", "Character");
					$ribbon->Commands[] = new RibbonButtonCommand("cmdLibraryCreateNewCostume", "Costume");
					$ribbon->Commands[] = new RibbonButtonCommand("cmdLibraryCreateNewMusician", "Musician");
					$ribbon->Commands[] = new RibbonButtonCommand("cmdLibraryCreateNewProducer", "Producer");
					$ribbon->Commands[] = new RibbonButtonCommand("cmdLibraryCreateNewSong", "Song");
					
					$cmdLibraryCreateNew = new RibbonDropDownCommand("cmdLibraryCreateNew", "New Item");
					$cmdLibraryCreateNew->Items[] = new RibbonCommandReferenceItem("cmdLibraryCreateNewAnimation");
					$cmdLibraryCreateNew->Items[] = new RibbonCommandReferenceItem("cmdLibraryCreateNewCharacter");
					$cmdLibraryCreateNew->Items[] = new RibbonCommandReferenceItem("cmdLibraryCreateNewCostume");
					$cmdLibraryCreateNew->Items[] = new RibbonCommandReferenceItem("cmdLibraryCreateNewMusician");
					$cmdLibraryCreateNew->Items[] = new RibbonCommandReferenceItem("cmdLibraryCreateNewProducer");
					$cmdLibraryCreateNew->Items[] = new RibbonCommandReferenceItem("cmdLibraryCreateNewSong");
					$ribbon->Commands[] = $cmdLibraryCreateNew;
					
					$ribbon->Commands[] = new RibbonButtonCommand("cmdLibraryImportExisting", "Import Existing...");
					
					$grpCreate->Items[] = new RibbonCommandReferenceItem("cmdLibraryCreateNew");
					$grpCreate->Items[] = new RibbonCommandReferenceItem("cmdLibraryImportExisting");
					$tabLibrary->Groups[] = $grpCreate;
					$ribbon->Tabs[] = $tabLibrary;
				}
				
				$grpAccount = new RibbonTabGroup("grpAccount", "Account");
				if (true /* is administrator */)
				{
					$ribbon->Commands[] = new RibbonButtonCommand("cmdProxyUser", "Proxy User", "~/account/proxy.page", null, "~/images/ribbon/logout.png");
					$grpAccount->Items[] = new RibbonCommandReferenceItem("cmdProxyUser");
				}
				$grpAccount->Items[] = new RibbonCommandReferenceItem("cmdLogOut");
				$tabHome->Groups[] = $grpAccount;
				
				$ribbon->Render();
				
				$this->scLeftRight->BeginContent();
				$this->scLeftRight->PrimaryPanel->BeginContent();
				
				$navpane = new Wunderbar("navpane");
				$navpane->Items[] = new WunderbarPanel("pnlTenantExplorer", "Tenant Explorer", function()
				{
				});
				$navpane->Items[] = new WunderbarPanel("pnlAdministrativeTasks", "Administrative Tasks", function()
				{
				});
				$navpane->Render();
				
				$this->scLeftRight->PrimaryPanel->EndContent();
				
				$this->scLeftRight->SecondaryPanel->BeginContent();
			}
		}
		protected function AfterContent()
		{
			if ($this->RenderChrome)
			{
				$this->scLeftRight->SecondaryPanel->EndContent();
				$this->scLeftRight->EndContent();
			}
		}
	}
?>