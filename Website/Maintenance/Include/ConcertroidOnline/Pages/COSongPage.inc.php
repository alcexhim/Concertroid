<?php
	namespace Concertroid\Online\Pages;
	
	class COSongListPage extends COListPage
	{
		public function __construct()
		{
			parent::__construct();
			
			$this->Columns = array
			(
				new COListColumn("SongName", "Title")
			);
		}
	}
	class COSongDetailPage extends \Concertroid\Online\COWebPage
	{
		public $Character;
		
		protected function RenderContent()
		{
?>
			<h1><?php echo ($this->Character->Title); ?> <span style="font-size: 10pt;">Character</span></h1>
			<table style="width: 100%">
				<tr>
					<td colspan="2" style="vertical-align: top;">
					<?php
						$panel = new WebPanelControl();
						$panel->Title = "Character Details";
						
						$panel->BeginContent();
					?>
					<table>
						<tr>
							<td style="width: 128px;">Title:</td>
							<td><?php echo($this->Character->Title); ?></td>
						</tr>
						<tr>
							<td>License:</td>
							<td><?php
								$wmlc = new WebMenuLinkControl("wmlcLicense", "Creative Commons CC-BY-SA 3.0 Unported", "~/Licenses/Creative_Commons_CC-BY-SA_3.0_Unported");
								$wmlc->MenuItems[] = new WebMenuItemCommand("Change License...", "#", "alert('showing license dialog');");
								$wmlc->Render();
							?></td>
						</tr>
					</table>
					<?php
						$panel->EndContent();
					?>
					</td>
				</tr>
				<tr>
					<td style="vertical-align: top;">
					<?php
						$panel = new WebPanelControl();
						$panel->Title = "Costumes available for this character";
						
						$panel->BeginContent();
						
						$costumes = $character->GetCostumes();
						echo(mysql_error());
						
						$i = 0; $c = count($costumes);
						foreach ($costumes as $costume)
						{
							$wmlc = new WebMenuLinkControl("wmlcCostume" . $character->ID . "_" . $costume->ID, $costume->Title, null, null, array
							(
								new WebMenuItemHeader($costume->Title, "Costume"),
								new WebMenuItemCommand("Search for characters who wear this costume")
							));
							$wmlc->Render();
							
							if ($i < $c - 1) echo("<br />");
							$i++;
						}
						
						$panel->EndContent();
					?>
					</td>
				</tr>
			</table>
<?php
		}
	}
?>