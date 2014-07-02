<?php
	namespace Objectify\Tenant\MasterPages;
	
	use WebFX\WebStyleSheet;
	use WebFX\System;
	
	use WebFX\Controls\Ribbon;
	use WebFX\Controls\RibbonTab;
	use WebFX\Controls\RibbonTabGroup;
	use WebFX\Controls\RibbonButtonCommand;
	use WebFX\Controls\RibbonCommandReferenceItem;
	
	class WebPage extends \WebFX\WebPage
	{
		public function __construct()
		{
			parent::__construct();
			
			$this->StyleSheets[] = new WebStyleSheet("http://static.alcehosting.net/dropins/WebFramework/StyleSheets/Workday/Main.css");
			$this->RenderRibbon = true;
		}
		
		public $RenderRibbon;
		
		protected function BeforeContent()
		{
			if ($this->RenderRibbon)
			{
				$ribbon = new Ribbon("ribbon");
				$ribbon->Title = "Concertroid Online Management Console";
				$ribbon->Commands[] = new RibbonButtonCommand("cmdLogOut", "Log Out", "~/account/logout.page", null, "~/images/ribbon/logout.png");
				
				$tabMain = new RibbonTab("tabMain", "Main");
				
				$grpAccount = new RibbonTabGroup("grpAccount", "Account");
				$grpAccount->Items[] = new RibbonCommandReferenceItem("cmdLogOut");
				$tabMain->Groups[] = $grpAccount;
				
				$ribbon->Tabs[] = $tabMain;
				
				$ribbon->Render();
			}
		}
	}
?>