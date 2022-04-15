/*
	This file is part of Goo Pumps & Oils' Speed Pump
		© 2022 Lisias T : http://lisias.net <support@lisias.net>
		© 2016-2019 hab136
		© 2015 Geordiepigeonowner
		© 2014 Gaius Goodspeed

	Goo Pumps & Oils' Speed Pump is licensed as follows:
		* GPL 3.0 : https://www.gnu.org/licenses/gpl-3.0.txt

	Goo Pumps & Oils' Speed Pump is distributed in the
	hope that it will be useful, but WITHOUT ANY WARRANTY; without even
	the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

	You should have received a copy of the GNU General Public License 3.0 along
	with Goo Pumps & Oils' Speed Pump. If not, see <https://www.gnu.org/licenses/>.
*/
using System.Collections.Generic;

namespace GPOSpeedPump
{
	public static class ModuleManagerSupport
	{
		public static IEnumerable<string> ModuleManagerAddToModList()
		{
			string[] r = { typeof(Version).Namespace };
			return r;
		}
	}
}
