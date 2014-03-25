<?php
	namespace Concertroid\Online\Pages;
	
	class COCharacterListPage extends COListPage
	{
		/*
		protected function RenderContent()
		{
?>
<table class="ListView" style="margin-left: auto; margin-right: auto;">
	<tr>
		<th>Character</th>
		<th>Costume(s)</th>
		<th>License</th>
	</tr>
	<tr class="Filter">
		<td>
			<form action="Characters" method="POST">
				<input class="Filter" type="text" name="filter_character" placeholder="Filter by character" value="<?php echo($_POST["filter_character"]); ?>" />
			</form>
		</td>
		<td>
			<form action="Characters" method="POST">
				<input class="Filter" type="text" name="filter_costume" placeholder="Filter by costume" value="<?php echo($_POST["filter_costume"]); ?>" />
			</form>
		</td>
		<td>
			<form action="Characters" method="POST">
				<input class="Filter" type="text" name="filter_license" placeholder="Filter by license" value="<?php echo($_POST["filter_license"]); ?>" />
			</form>
		</td>
	</tr>
<?php
	$characters = Character::Get();
	$alternate = false;
	foreach ($characters as $character)
	{
		if ($_POST["filter_character"] != null)
		{
			if (mb_stripos($character->Title, $_POST["filter_character"]) === false) continue;
		}
		if ($_POST["filter_costume"] != null)
		{
			$xerxes = false;
			$costumes = $character->GetCostumes();
			foreach ($costumes as $costume)
			{
				if (mb_stripos($costume->Title, $_POST["filter_costume"]) === false)
				{
					$xerxes = true;
					break;
				}
			}
			if ($xerxes) continue;
		}
		if ($_POST["filter_license"] != null)
		{
			if (mb_stripos($character->License->Title, $_POST["filter_license"]) === false) continue;
		}
?>
	<tr<?php if ($alternate) echo(" class=\"Alternate\""); ?>>
		<td>
		<?php
			$wmlc = new WebMenuLinkControl("wmlcCharacter" . $character->ID, $character->Title, "~/Characters/" . $character->Name, null, array
			(
				new WebMenuItemHeader($character->Title, "Character"),
				new WebMenuItemCommand("Add to concert characters"),
				new WebMenuItemCommand("Edit character details")
			));
			$wmlc->Render();
		?>
		</td>
		<td>
		<?php
			$costumes = $character->GetCostumes();
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
		?>
		</td>
		<td>
		<?php
			$license = $character->License;
			if ($license == null)
			{
				echo("(unspecified)");
			}
			else
			{
				$wmlc = new WebMenuLinkControl("wmlcLicense" . $character->ID . "_", $license->Title, null, null, array
				(
					new WebMenuItemHeader($license->Title, "License"),
					new WebMenuItemCommand("View full text of this license"),
					new WebMenuItemCommand("Modify this license")
				));
				$wmlc->Render();
			}
		?>
		</td>
	</tr>
<?php
		$alternate = !$alternate;
	}
?>
</table>
<?php
		}
		*/
	}
	class COCharacterDetailPage extends \Concertroid\Online\COWebPage
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