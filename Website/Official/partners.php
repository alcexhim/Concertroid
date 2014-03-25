<?php
	include_once("include/system.inc.php");
	
	$path = getpath();
	if ($path != null)
	{
		$query = "SELECT * FROM cr_partners";
		if (count($path) > 0)
		{
			$num_id = $path[0];
			if (is_numeric($num_id))
			{
				$query .= " WHERE crp_id = " . $num_id;
			}
			else
			{
				$query .= " WHERE crp_name = '" . mysql_real_escape_string($num_id) . "'";
			}
		
			$result = mysql_query($query);
			$row = mysql_fetch_assoc($result);
			
			if (count($path) > 1)
			{
				switch ($path[1])
				{
					case "images":
					{
						if (count($path) > 2)
						{
							$filename = "images/partners/" . $row["crp_name"] . "/" . $path[2] . ".png";
							if (!file_exists($filename))
							{
								echo("File not found");
								return;
							}
							header("Content-Type: " . mime_content_type($filename));
							readfile($filename);
							return;
						}
						break;
					}
				}
			}
			else
			{
				header("Location: " . $row["crp_website"]);
			}
		}
		return;
	}
	else
	{
		page_begin("Partners");
?>
<h3>Collaborate and connect with people from around the world</h3>
<p>
	Concertroid is a community effort. We would like to promote your events and activities for the
	global virtual singer community. If you would like to become a Concertroid partner, first
	<a href="/account/login">log in</a> (or <a href="/account/register">register</a> if you do not
	already have a Concertroid Online account).
</p>
<p>
	Our partners make no profit from being associated with us, and we likewise receive no monetary
	compensation for listing them here. At this time, all we do is promote their events, and they
	promote us the same.
</p>
<?php
	// commence database reading
	$query = "SELECT * FROM cr_partners";
	$result = mysql_query($query);
	$count = mysql_num_rows($result);
	
	echo("<div class=\"TilesView\" style=\"text-align: center;\">");
	for ($i = 0; $i < $count; $i++)
	{
		$row = mysql_fetch_assoc($result);
		echo("<a class=\"Tile\" href=\"/partners/" . $row["crp_name"] . "\" target=\"_blank\">");
		echo("<img class=\"TileImage\" src=\"/partners/" . $row["crp_name"] . "/images/banner\" alt=\"(image unavailable)\" /><br />");
		echo("<span class=\"TileTitle\">" . $row["crp_title"] . "</span>");
		echo("</a>");
	}
	echo("</div>");
?>
<?php
		page_end();
	}
?>