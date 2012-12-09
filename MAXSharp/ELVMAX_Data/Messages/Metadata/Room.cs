using System;
using System.Collections.Generic;
using System.Text;

namespace MAXSharp
{
	public class Room
	{
		public String RoomName;
		public Byte RoomID;
		public String RFAddress;
		public Dictionary<String,IMAXDevice> Devices;
		public House AssociatedHouse;

		public override string ToString ()
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("RoomName: "+RoomName);
			sb.AppendLine("RoomID: "+RoomID);
			sb.AppendLine("RFAddress: "+RFAddress);
			sb.AppendLine("Devices:");

			foreach(IMAXDevice _device in Devices.Values)
			{
				sb.Append(_device.ToString());
				sb.AppendLine();
			}

			return sb.ToString();
		}

		public Room (House _House)
		{
			AssociatedHouse = _House;
			Devices = new Dictionary<String,IMAXDevice>();
		}
	}
}

