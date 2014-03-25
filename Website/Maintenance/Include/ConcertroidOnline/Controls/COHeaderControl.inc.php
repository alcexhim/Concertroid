<?php
	namespace Concertroid\Online\Controls;
	
	use System;
	use Concertroid\Online\Objects\User;
	
	use WebFramework\Controls\TextBox;
	
	class COHeaderControl extends \WebFramework\WebControl
	{
		protected function RenderContent()
		{
			$user = User::GetCurrent();
			
?>
			<div class="Header">
				<a href="<?php echo(System::ExpandRelativePath("~/")); ?>"><img src="<?php echo(System::ExpandRelativePath("~/Images/Icons/MainIcon.png")); ?>" style="height: 32px;" /></a>
				<?php
				$txtSearch = new TextBox("txtSearch");
				$txtSearch->PlaceholderText = "Search";
				$txtSearch->InnerStyle = "display: inline-block; height: 32px; position: absolute; left: 72px; top: 4px; width: 256px; font-size: 16pt;";
				$txtSearch->Render();
				// <input type="text" placeholder="Search" style="" />
				?>
				<script type="text/javascript">
					var items =
					[
						{ "ID": 1, "Text": "Create Band", "URL": "<?php echo(System::ExpandRelativePath("~/Bands/Create.page")); ?>" },
						{ "ID": 2, "Text": "Create Character", "URL": "<?php echo(System::ExpandRelativePath("~/Characters/Create.page")); ?>" },
						{ "ID": 3, "Text": "Create Concert", "URL": "<?php echo(System::ExpandRelativePath("~/Concerts/Create.page")); ?>" }
					];
					
					txtSearch.FormatItemID = function(item)
					{
						return item.ID;
					};
					txtSearch.FormatItemText = function(item)
					{
						return "<a href=\"" + item.URL + "\" " + (item.OnClientClick ? ("onclick=\"" + item.OnClientClick + "\"") : "") + ">" + item.Text + "</a>";
					};
					txtSearch.Suggest = function(value)
					{
						var retval = [];
						for (var i = 0; i < items.length; i++)
						{
							if (items[i].Text.toLowerCase().indexOf(value) != -1)
							{
								retval.push(items[i]);
							}
						}
						return retval;
					};
				</script>
				<a class="UserName" href="#account"><?php echo($user->Title); ?></a>
			</div>
<?php
		}
	}
?>