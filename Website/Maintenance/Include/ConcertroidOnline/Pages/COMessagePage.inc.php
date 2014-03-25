<?php
	namespace Concertroid\Online\Pages;
	
	use System;
	
	class COMessagePage extends \Concertroid\Online\COWebPage
	{
		public $Message;
		public $Description;
		public $ReturnButtonURL;
		public $ReturnButtonText;
		public $ImageURL;
		
		protected function RenderContent()
		{
?>
<div class="Panel" style="margin: 100px auto 0; width: 575px;">
	<table style="width: 100%; border: none 0px;">
		<tr>
			<td rowspan="2" style="vertical-align: top;"><?php if ($this->ImageURL != null) { ?><img class="Icon" style="width: 48px; height: 48px;" src="<?php echo(System::ExpandRelativePath($this->ImageURL)); ?>" /><?php } ?></td>
			<td style="vertical-align: top;"><div class="PanelTitle"><?php echo($this->Message); ?></div></td>
		</tr>
		<tr>
			<td style="vertical-align: top;">
				<div class="PanelContent">
				<?php echo($this->Description); ?>
				</div>
			</td>
		</tr>
		<tr>
			<td colspan="2" style="vertical-align: top;">
				<div style="text-align: center; padding-top: 16px;">
					<a href="<?php echo(System::ExpandRelativePath($this->ReturnButtonURL)); ?>"><?php echo($this->ReturnButtonText); ?></a>
				</div>
			</td>
		</tr>
	</table>
</div>
<?php
		}
	}
?>