<?php
	namespace Concertroid\Online\Pages;
	
	use System;
	
	use WebFramework\WebPageCommand;
	use WebFramework\Controls\WebMenuLinkControl;
	use WebFramework\Controls\WebMenuItemHeader;
	use WebFramework\Controls\WebMenuItemCommand;
	
	use Concertroid\Objects\Library;
	
	class COLibraryListPage extends COListPage
	{
		public function __construct()
		{
			parent::__construct();
			$this->Title = "Libraries";
			$this->Commands = array
			(
				new WebPageCommand("Create a library", "~/Libraries/!/Create", "CreateLibraryDialog.ShowDialog();")
			);
			
			$this->Columns = array
			(
				new COListColumn("Library", "Library", null, "256px"),
				new COListColumn("Description", "Description"),
				new COListColumn("CreationUser", "Created by", null, "128px"),
				new COListColumn("CreationTimestamp", "Created on", null, "128px")
			);
			
			$items = Library::Get();
			foreach ($items as $item)
			{
				$listitem = new COListItem(array
				(
					new COListItemColumn("Library", $item->Title, $item->Title, function($item)
					{
						$wmlc = new WebMenuLinkControl("wmlcLibrary" . $item->ID, $item->Title, "~/Libraries/" . $item->Name, null, array
						(
							new WebMenuItemHeader($item->Title, "Library"),
							new WebMenuItemCommand("Download")
						));
						$wmlc->Render();
					}, $item),
					new COListItemColumn("Description", $item->Description, $item->Description),
					new COListItemColumn("CreationUser", "", "", function ($user)
					{
						if ($user != null)
						{
							$wmlc = new WebMenuLinkControl("wmlcLibrary" . $item->ID . "CreationUser", $user->UserName, "~/Users/" . $user->UserName, null, array
							(
								new WebMenuItemHeader($user->UserName, "User"),
								new WebMenuItemCommand("Contact this person")
							));
							$wmlc->Render();
						}
						else
						{
							echo("(system delivered)");
						}
					}, $item->CreationUser),
					new COListItemColumn("CreationTimestamp", $item->CreationTimestamp, $item->CreationTimestamp)
				));
				$this->Items[] = $listitem;
			}
		}
	}
	class COLibraryDetailPage extends \Concertroid\Online\COWebPage
	{
		public $Item;
		
		protected function RenderContent()
		{
?>
			<h1><?php echo ($this->Item->Title); ?> <span style="font-size: 10pt;">Library</span></h1>
			<table style="width: 100%">
				<tr>
					<td colspan="2" style="vertical-align: top;">
					<?php
						$panel = new WebPanelControl();
						$panel->Title = "Library Details";
						
						$panel->BeginContent();
					?>
					<table>
						<tr>
							<td style="width: 128px;">Title:</td>
							<td><?php echo($this->Item->Title); ?></td>
						</tr>
						<tr>
							<td>Description:</td>
							<td><?php echo($this->Item->Description); ?></td>
						</tr>
					</table>
					<?php
						$panel->EndContent();
					?>
					</td>
				</tr>
			</table>
<?php
		}
	}
?>