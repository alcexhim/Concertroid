<?php
	namespace Concertroid\Online\Pages;
	
	use WebFramework\Controls\ButtonGroup;
	use WebFramework\Controls\ButtonGroupButton;
	
	class COMainPage extends \Concertroid\Online\COWebPage
	{
		protected function RenderContent()
		{
			$buttongroup = new ButtonGroup("btngMainMenu");
			$buttongroup->Items = array
			(
				new ButtonGroupButton("cmdConcerts", "Concerts", "Manage my concerts", "~/Images/Buttons/Concerts.png", "~/Concerts"),
				new ButtonGroupButton("cmdLibraries", "Libraries", "View available libraries", "~/Images/Buttons/Libraries.png", "~/Libraries")
			);
			$buttongroup->Render();
		}
	}
?>