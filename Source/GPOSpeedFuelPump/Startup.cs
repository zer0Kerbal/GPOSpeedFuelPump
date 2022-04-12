/*
	This file is part of Goo Pumps & Oils' Speed Fuel Pump
		© 2022 Lisias T : http://lisias.net <support@lisias.net>
		© 2016-2019 hab136
		© 2015 Geordiepigeonowner
		© 2014 Gaius Goodspeed

	Goo Pumps & Oils' Speed Fuel Pump is licensed as follows:
		* GPL 3.0 : https://www.gnu.org/licenses/gpl-3.0.txt

	Goo Pumps & Oils' Speed Fuel Pump is distributed in the
	hope that it will be useful, but WITHOUT ANY WARRANTY; without even
	the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

	You should have received a copy of the GNU General Public License 3.0 along
	with Goo Pumps & Oils' Speed Fuel Pump. If not, see <https://www.gnu.org/licenses/>.
*/
using UnityEngine;

namespace GPOSpeedFuelPump
{
	[KSPAddon(KSPAddon.Startup.Instantly, true)]
	internal class Startup:MonoBehaviour
	{
		private void Start()
		{
			Log.force("Version {0}", Version.Text);

			try
			{
				//KSPe.Util.Compatibility.Check<Startup>(typeof(Version), typeof(Configuration));
				KSPe.Util.Installation.Check<Startup>(typeof(Version));
			}
			catch (KSPe.Util.InstallmentException e)
			{
				Log.err(e.ToShortMessage());
				KSPe.Common.Dialogs.ShowStopperAlertBox.Show(e);
			}
		}
	}
}
