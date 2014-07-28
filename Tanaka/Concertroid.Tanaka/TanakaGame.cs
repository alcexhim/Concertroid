using System;
using PJLink;

namespace ConcertroidTanaka
{
	public class TanakaGame : Tanaka.Game
	{
		private Projector proj = null;
		protected override void Create ()
		{
			base.Create ();
			proj = Projector.FromAddress ("192.168.1.22");
			proj.Connect("panasonic");
			proj.SetPowerState (PowerState.On);
			proj.Mute = true;
		}
		protected override void Destroy ()
		{
			base.Destroy ();
			proj.SetPowerState (PowerState.Off);
		}
	}
}

