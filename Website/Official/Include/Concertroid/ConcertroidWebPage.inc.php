<?php
	use \WebFramework\WebPage;
	use \WebFramework\WebPageMetadata;
	use \WebFramework\WebResourceLink;
	use \WebFramework\WebStyleSheet;
	use \WebFramework\WebScript;
	
	class ConcertroidWebPage extends WebPage
	{
		public function Initialize()
		{
			$this->Metadata = array
			(
				new WebPageMetadata("author", "ALCEproject Group"),
				new WebPageMetadata("description", ""),
				new WebPageMetadata("keywords", "Concertroid,VOCALOID,AniMiku")
			);
			
			$this->StyleSheets = array
			(
				new WebStyleSheet("~/style/main.css"),
				new WebStyleSheet("~/style/" . \System::$Configuration["Application.Theme"] . "/main.css"),
				new WebStyleSheet("~/style/metro/main.css")
			);
			
			$this->ResourceLinks = array
			(
				new WebResourceLink("https://plus.google.com/113166192060752748250", "publisher")
			);
			
			if ($CurrentUser != null && $CurrentUser->Theme != null)
			{
				$this->StyleSheets[] = new WebStyleSheet("~/style/themes/" . $CurrentUser->Theme->Name . ".css");
			}
			
			$this->Scripts = array
			(
				new WebScript("~/script/jquery_min.js"),	// JQuery
				new WebScript("~/script/XMLHttpRequest.js"),		// XMLHttpRequest
				
				new WebScript("~/script/presence.js"),		// Presence
				new WebScript("~/script/window.js"),		// Window
				new WebScript("~/script/ooWindow.js"),		// ooWindow
				new WebScript("~/script/chance.js"),		// Chance
				
				new WebScript("~/script/TypeaheadTextBox.js"),		// Type-ahead text box
				new WebScript("~/script/AutoGenerateName.js"),		// Auto-generate names
				new WebScript("~/script/TabContainer.js"),		// Tab container
				new WebScript("~/script/ValidatePassword.js"),		// Validate password
				new WebScript("~/script/InlineSearch.js"),		// Inline search
				new WebScript("~/script/TicketDispenser.js")		// Ticket dispenser
			);
			
			if ($this->Title == null)
			{
				$this->Title = System::$Configuration["Application.Name"];
			}
			else
			{
				$this->Title .= " | " . System::$Configuration["Application.Name"];
			}
		}
		public function BeforeRenderContent()
		{
?>
		<div class="Page">
			<div class="Navigation">
				<span style="float: left; color: #666666">
					<a href="<?php echo(\System::ExpandRelativePath("~/")); ?>" style="padding-left: 155px; margin-right: 15px;">&nbsp;</a> professional virtual concert production</span>
					<?php /* <span><a class="NavigationLink AccountNavigationLink" href="/account">Account</a></span> */ ?>
					<a href="<?php echo(\System::ExpandRelativePath("~/events")); ?>">Events</a>
					<a href="<?php echo(\System::ExpandRelativePath("~/products")); ?>">Products</a>
					<a href="<?php echo(\System::ExpandRelativePath("~/partners")); ?>">Partners</a>
					<a href="<?php echo(\System::ExpandRelativePath("~/about.php")); ?>">About</a>
			</div>
<?php
		}
		public function AfterRenderContent()
		{
?>
		</div>
<?php
		}
	}
?>