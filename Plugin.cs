using System;
using Maximility.Menu;
using MelonLoader;
using Photon.Pun;
using Photon.VR;
using UnityEngine;

namespace Maximility
{
	public class Plugin : MelonMod
	{
        #region Main

        public bool menuInitialized;

        public override void OnUpdate()
		{
			if (!this.menuInitialized)
			{
				Menu.Menu.LoadOnce();
				this.menuInitialized = true;
			}

			Menu.Menu.Load();

			new ModManager().Mods();

			if (!PhotonNetwork.IsConnected)
			{
				PhotonNetwork.ConnectUsingSettings();
			}
		}

		#endregion

		#region Bools

		//Movement Bools
		public static bool ExcelFly;
        public static bool TFly;

        #endregion
    }
}
