<?php
	namespace Concertroid\Online\Controls;
	
	class COSongDetailPanelControl extends \WebFramework\WebControl
	{
		public $SongID;
		
		private $Title;
		private $Producer;
		
		
		public function __construct($songID)
		{
			$this->SongID = $songID;
			$this->Title = "Yume Yume";
			$this->Producer = "DECO*27";
		}
		
		protected function RenderContent()
		{
			$panel = new WebPanelControl($this->Title . " by " . $this->Producer);
			$panel->Width = "400px";
			$panel->HorizontalAlignment = "center";
			$panel->BeginContent();
?>
<table style="width: 100%;">
	<tr>
		<td style="width: 100px;">
			Song:
		</td>
		<td>
			<?php
				$clwmSong = new WebMenuLinkControl("clwmSong", "Yume Yume");
				$clwmSong->MenuItems[] = new WebMenuItemCommand("Check permission status");
				$clwmSong->MenuItems[] = new WebMenuItemCommand("Select audio file");
				$clwmSong->MenuItems[] = new WebMenuItemCommand("Check permission status");
				$clwmSong->MenuItems[] = new WebMenuItemCommand("Select audio file");
				$clwmSong->MenuItems[] = new WebMenuItemCommand("Check permission status");
				$clwmSong->MenuItems[] = new WebMenuItemCommand("Select audio file");
				$clwmSong->MenuItems[] = new WebMenuItemCommand("Check permission status");
				$clwmSong->MenuItems[] = new WebMenuItemCommand("Select audio file");
				$clwmSong->Render();
			?>
		</td>
	</tr>
	<tr>
		<td>
			Producer:
		</td>
		<td>
			<?php
				$clwmProducer = new WebMenuLinkControl("clwmProducer", "DECO*27");
				$clwmProducer->MenuItems[] = new WebMenuItemCommand("Find similar producers");
				$clwmProducer->MenuItems[] = new WebMenuItemCommand("View all songs by this producer");
				$clwmProducer->Render();
			?>
		</td>
	</tr>
	<tr>
		<td>
			File name:
		</td>
		<td>
			<?php
				$clwmFile = new WebMenuLinkControl("clwmFile", "/Songs/YumeYume.ogg");
				$clwmFile->MenuItems[] = new WebMenuItemCommand("Download this song to your computer");
				$clwmFile->Render();
			?>
		</td>
	</tr>
</table>
<p>
	This song is not on your set list. <a href="#">Add it to a set list...</a>
</p>
<?php
			$panel->EndContent();
		}
	}
?>