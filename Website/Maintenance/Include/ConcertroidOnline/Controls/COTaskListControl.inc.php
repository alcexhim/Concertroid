<?php
	namespace Concertroid\Online\Controls;
	
	use WebFramework\WebControl;
	use WebFramework\Controls\WebPanelControl;
	use WebFramework\Controls\WebActionListCommand;
	use WebFramework\Controls\WebActionListGroup;
	use WebFramework\Controls\WebMenuItemCommand;
	
	class COTaskListControl extends WebControl
	{
		protected function RenderContent()
		{
			$panel = new WebPanelControl();
			$panel->Width = "40%";
			$panel->HorizontalAlignment = "center";
			
			$panel->Title = "To-Do List";
			
			$panel->BeginContent();
			
			$actionlist = new WebActionListControl();
			
			// 0 = not started, 1 = pending, 2 = completed
			$items = Costume::GetIncomplete();
			$c = count($items);
			if ($c > 0)
			{
				$m = min($c, 5);
				$alg = new WebActionListGroup("Finish designing costumes (" . $c . ")");
				for ($i = 0; $i < $m; $i++)
				{
					$item = new WebActionListCommand($items[$i]->Title, "~/Costumes/" . $items[$i]->Name);
					$alg->Items[] = $item;
				}
				$r = $c - $m;
				if ($r > 0)
				{
					if ($r == 1)
					{
						$r = $r . " others";
					}
					else
					{
						$r = $r . " other";
					}
					$alg->MoreCommand = new WebActionListCommand("(and " . $r . "...)", "~/Costumes/");
				}
				$actionlist->Items[] = $alg;
			}
			
			$items = Animation::GetIncomplete();
			$c = count($items);
			if ($c > 0)
			{
				$m = min($c, 5);
				$alg = new WebActionListGroup("Complete animating performances (" . $c . ")");
				for ($i = 0; $i < $m; $i++)
				{
					$item = new WebActionListCommand($items[$i]->Title, "~/Animations/" . $items[$i]->Name);
					$alg->Items[] = $item;
				}
				$r = $c - $m;
				if ($r > 0)
				{
					if ($r == 1)
					{
						$r = $r . " others";
					}
					else
					{
						$r = $r . " other";
					}
					$alg->MoreCommand = new WebActionListCommand("(and " . $r . "...)", "~/Animations/");
				}
				$actionlist->Items[] = $alg;
			}
			
			$items = Song::GetUnauthorized();
			$c = count($items);
			if ($c > 0)
			{
				$m = min($c, 5);
				$alg = new WebActionListGroup("Request permission for songs (" . $c . ")");
				for ($i = 0; $i < $m; $i++)
				{
					$item = new WebActionListCommand($items[$i]->Title, "~/Songs/" . $items[$i]->Name);
					$item->MenuItems[] = new WebMenuItemMenu("Set permission status",
					array
					(
						new WebMenuItemCommand("Not requested"),
						new WebMenuItemCommand("Pending"),
						new WebMenuItemCommand("Approved"),
						new WebMenuItemCommand("Denied"),
						new WebMenuItemCommand("Not required"),
						new WebMenuItemCommand("Licensed (ASCAP/JASRAC)")
					));
					$alg->Items[] = $item;
				}
				$r = $c - $m;
				if ($r > 0)
				{
					if ($r == 1)
					{
						$r = $r . " others";
					}
					else
					{
						$r = $r . " other";
					}
					$alg->MoreCommand = new WebActionListCommand("(and " . $r . "...)", "~/Songs/");
				}
				$actionlist->Items[] = $alg;
			}
			
			$algOther = new WebActionListGroup("Other concert tasks that have not yet been completed (2)");
			$algOther->Items[] = new WebActionListCommand("Book a venue");
			$algOther->Items[] = new WebActionListCommand("Advertise your event");
			$actionlist->Items[] = $algOther;
			
			$actionlist->Render();
			
			$panel->EndContent();
		}
	}
?>