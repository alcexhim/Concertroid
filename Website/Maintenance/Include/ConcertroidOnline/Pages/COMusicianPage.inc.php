<?php
	namespace Concertroid\Online\Pages;
	
	use System;
	
	use WebFramework\WebPageCommand;
	use WebFramework\Controls\LinkButton;
	use WebFramework\Controls\ListView;
	use WebFramework\Controls\ListViewColumn;
	use WebFramework\Controls\ListViewItem;
	use WebFramework\Controls\ListViewItemColumn;
	use WebFramework\Controls\MenuItemHeader;
	use WebFramework\Controls\MenuItemCommand;
	use WebFramework\Controls\Panel;
	
	use Concertroid\Objects\Musician;
	use Concertroid\Objects\Instrument;
	
	class COMusicianListPage extends COListPage
	{
		public function __construct()
		{
			parent::__construct();
			
			$this->Columns = array
			(
				new ListViewColumn("Musician", "Musician"),
				new ListViewColumn("Instruments", "Instrument(s)"),
				new ListViewColumn("AssociatedBands", "Associated band(s)")
			);
			
			$musicians = Musician::Get();
			foreach ($musicians as $musician)
			{
				$instrumentsStr = "";
				$instrumentsStr2 = "";
				
				
				$instruments = $musician->GetInstruments();
				$i = 0; $c = count($instruments);
				foreach ($instruments as $instrument)
				{
					/*
					$wmlc = new LinkButton("wmlcInstrument" . $musician->ID . "_" . $instrument->ID, $instrument->Title, null, null, array
					(
						new MenuItemHeader($instrument->Title, "Instrument"),
						new MenuItemCommand("Search for band members who play this instrument"),
						new MenuItemCommand("Search for guest musicians who play this instrument"),
						new MenuItemCommand("See all musicians who play this instrument")
					));
					$wmlc->Render();
					*/
					
					$instrumentsStr .= $instrument->Title;
					$instrumentsStr2 .= $instrument->Title;
					if ($i < $c - 1)
					{
						$instrumentsStr .= "<br />";
						$instrumentsStr2 .= " ";
					}
					$i++;
				}
				
				$item = new ListViewItem(array
				(
					new ListViewItemColumn("Musician", $musician->Title, $musician->Title, function($musicianObj)
					{
						$wmlc = new LinkButton("wmlcMusician" . $musicianObj->ID, $musicianObj->Title, "~/Musicians/" . $musicianObj->Name, null, array
						(
							new MenuItemHeader($musicianObj->Title, "Musician"),
							new MenuItemCommand("Add to band musicians"),
							new MenuItemCommand("Contact this musician"),
							new MenuItemCommand("Edit musician details"),
							new MenuItemCommand("Visit Web site"),
							new MenuItemCommand("Read personal blog")
						));
						$wmlc->Render();
					}, $musician),
					new ListViewItemColumn("Instruments", $instrumentsStr, $instrumentsStr2, function($data)
					{
						$musicianObj = $data[0];
						$instrumentsObj = $data[1];
						
						$i = 0; $c = count($instrumentsObj);
						foreach ($instrumentsObj as $instrument)
						{
							$wmlc = new LinkButton("wmlcInstrument" . $musicianObj->ID . "_" . $instrument->ID, $instrument->Title, null, null, array
							(
								new MenuItemHeader($instrument->Title, "Instrument"),
								new MenuItemCommand("Search for band members who play this instrument"),
								new MenuItemCommand("Search for guest musicians who play this instrument"),
								new MenuItemCommand("See all musicians who play this instrument")
							));
							$wmlc->Render();
							
							if ($i < $c - 1) echo("<br />");
							$i++;
						}
					}, array($musician, $instruments)),
					new ListViewItemColumn("AssociatedBands", "The 39s", "The 39s", function($musicianObj)
					{
						/*
						$i = 0; $c = count($instrumentsObj);
						foreach ($instrumentsObj as $instrument)
						{
							$wmlc = new LinkButton("wmlcInstrument" . $musicianObj->ID . "_" . $instrument->ID, $instrument->Title, null, null, array
							(
								new MenuItemHeader($instrument->Title, "Instrument"),
								new MenuItemCommand("Search for band members who play this instrument"),
								new MenuItemCommand("Search for guest musicians who play this instrument"),
								new MenuItemCommand("See all musicians who play this instrument")
							));
							$wmlc->Render();
							
							if ($i < $c - 1) echo("<br />");
							$i++;
						}
						*/
						$wmlc = new LinkButton("wmlcAssociatedBand" . $musicianObj->ID . "_1", "The 39s", null, null, array
						(
							new MenuItemHeader("The 39s", "Band"),
							new MenuItemCommand("Search for band members associated with this band"),
							new MenuItemCommand("Hire this band for an upcoming event")
						));
						$wmlc->Render();
						echo("<br />");
						$wmlc = new LinkButton("wmlcAssociatedBand" . $musicianObj->ID . "_2", "MKP39 (first generation)", null, null, array
						(
							new MenuItemHeader("MKP39 (first generation)", "Band"),
							new MenuItemCommand("Search for band members associated with this band"),
							new MenuItemCommand("Hire this band for an upcoming event")
						));
						$wmlc->Render();
						echo("<br />");
						$wmlc = new LinkButton("wmlcAssociatedBand" . $musicianObj->ID . "_3", "MKP39 (second generation)", null, null, array
						(
							new MenuItemHeader("MKP39 (second generation)", "Band"),
							new MenuItemCommand("Search for band members associated with this band"),
							new MenuItemCommand("Hire this band for an upcoming event")
						));
						$wmlc->Render();
						echo("<br />");
						$wmlc = new LinkButton("wmlcAssociatedBand" . $musicianObj->ID . "_4", "Magical Mirai Band", null, null, array
						(
							new MenuItemHeader("Magical Mirai Band", "Band"),
							new MenuItemCommand("Search for band members associated with this band"),
							new MenuItemCommand("Hire this band for an upcoming event")
						));
						$wmlc->Render();
						echo("<br />");
					}, $musician)
				));
				
				$this->Items[] = $item;
			}
		}
	}
	class COMusicianDetailPage extends \Concertroid\Online\COWebPage
	{
		public $Musician;
		
		protected function RenderContent()
		{
?>
			<h1><?php echo ($this->Musician->Title); ?> <span style="font-size: 10pt;">Musician</span></h1>
			<table style="width: 100%">
				<tr>
					<td style="vertical-align: top; width: 256px;">
					<?php
						$panel = new Panel();
						$panel->Title = "Common Tasks";
						
						$panel->BeginContent();
					?>
					<div class="Menu">
						<a class="MenuItem" href="<?php echo(System::ExpandRelativePath("~/Musicians/" . $this->Musician->Name . "/Edit")); ?>">Edit Musician Details</a>
					</div>
					<?php
						$panel->EndContent();
					?>
					</td>
					<td style="vertical-align: top;">
					<?php
						$panel = new WebPanelControl();
						$panel->Title = "Musician Details";
						
						$panel->BeginContent();
					?>
					<table>
						<tr>
							<td style="width: 128px;">Local ID:</td>
							<td><?php echo(UUID::format($this->Musician->LocalIdentifier)); ?></td>
						</tr>
						<tr>
							<td>Instruments:</td>
							<td>
							<?php
								$instruments = $this->Musician->GetInstruments();
								$i = 0; $c = count($instruments);
								foreach ($instruments as $instrument)
								{
									$wmlc = new LinkButton("wmlcInstrument" . $musician->ID . "_" . $instrument->ID, $instrument->Title, null, null, array
									(
										new MenuItemHeader($instrument->Title, "Instrument"),
										new MenuItemCommand("Search for band members who play this instrument"),
										new MenuItemCommand("Search for guest musicians who play this instrument"),
										new MenuItemCommand("See all musicians who play this instrument")
									));
									$wmlc->Render();
									
									if ($i < $c - 1) echo("<br />");
									$i++;
								}
							?>
							</td>
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