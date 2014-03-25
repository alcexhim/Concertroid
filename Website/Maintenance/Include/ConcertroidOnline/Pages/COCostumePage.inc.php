<?php
	namespace Concertroid\Online\Pages;
	
	class COCostumeListPage extends COListPage
	{
		protected function RenderContent()
		{
			
		}
	}
	class COCostumeDetailPage extends \Concertroid\Online\COWebPage
	{
		public $Costume;
		
		protected function RenderContent()
		{
?>
			<h1><?php echo ($this->Costume->Title); ?> <span style="font-size: 10pt;">Costume</span></h1>
			<table style="width: 100%">
				<tr>
					<td colspan="2" style="vertical-align: top;">
					<?php
						$panel = new WebPanelControl();
						$panel->Title = "Costume Details";
						
						$panel->BeginContent();
					?>
					<table>
						<tr>
							<td style="width: 128px;">Local ID:</td>
							<td><?php echo(UUID::format($this->Costume->LocalIdentifier)); ?></td>
						</tr>
						<tr>
							<td>Status:</td>
							<td>
							<?php
								$wmlc = new WebMenuLinkControl("wmlcStatus", "In Progress");
								$wmlc->MenuItems = array
								(
									new WebMenuItemCommand("Not Started"),
									new WebMenuItemCommand("In Progress"),
									new WebMenuItemCommand("Completed")
								);
								$wmlc->Render();
							?>
							</td>
						</tr>
						<tr>
							<td>License:</td>
							<td>
							<?php
								$wmlc = new WebMenuLinkControl("wmlcLicense", $this->Costume->License->Title, $this->Costume->License->URL);
								$wmlc->MenuItems[] = new WebMenuItemCommand("Change License...", "#", "alert('showing license dialog');");
								$wmlc->Render();
							?>
							</td>
						</tr>
						<tr>
							<td>Model filename:</td>
							<td>
							<?php
								$wmlc = new WebMenuLinkControl("wmlcModel", "Rin_Hikarisyuyo_PMD_ver1.0.pmd", "~/Files/Rin_Hikarisyuyo_PMD_ver1.0.pmd");
								$wmlc->Render();
							?>
							</td>
						</tr>
					</table>
					<?php
						$panel->EndContent();
					?>
					</td>
				</tr>
				<tr>
					<td style="width: 50%; vertical-align: top;">
					<?php
						$panel = new WebPanelControl();
						$panel->Title = "Producers";
						
						$panel->BeginContent();
						
						$al = new WebActionListControl();
						
						$producers = $this->Costume->GetProducers();
						foreach ($producers as $producer)
						{
							$al->Items[] = new WebActionListCommand($producer->Title, "~/Producers/" . $producer->Name, null, array
							(
								new WebMenuItemCommand("Contact this producer")
							));
						}
						
						$al->Render();
						$panel->EndContent();
					?>
					</td>
					<td style="vertical-align: top;">
					<?php
						$panel = new WebPanelControl();
						$panel->Title = "Characters that use this costume";
						
						$panel->BeginContent();
						
						$al = new WebActionListControl();
						$alc = new WebActionListCommand("Hatsune Miku", "~/Characters/Hatsune_Miku", null, array
						(
							new WebMenuItemCommand("Test"),
							new WebMenuItemCommand("View character details")
						));
						$al->Items[] = $alc;
						
						$alc = new WebActionListCommand("Kagamine Rin", "~/Characters/Kagamine_Rin", null, array
						(
							new WebMenuItemCommand("Test"),
							new WebMenuItemCommand("View character details")
						));
						$al->Items[] = $alc;
						
						$al->Render();
						$panel->EndContent();
					?>
					</td>
				</tr>
			</table>
<?php
		}
	}
?>