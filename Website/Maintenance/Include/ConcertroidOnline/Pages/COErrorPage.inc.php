<?php
	namespace Concertroid\Online\Pages;
	
	class COErrorPage extends COMessagePage
	{
		public function __construct()
		{
			parent::__construct();
			$this->ImageURL = "~/images/icons/error.png";
		}
	}
?>