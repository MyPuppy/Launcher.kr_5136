using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace KartRider
{
	public class SessionGroup
	{
		public object m_lock = new object();

		public ClientSession Client
		{
			get;
			set;
		}

		public int TimeAttackStartTicks = 0;
		public int SendPlaneCount = 6;
		public int TotalSendPlaneCount = 6;
		public byte PlaneCheck1 = 0;

		public static uint LucciMax = 9999999;

		public static ushort usLocale = 1002;
		public static byte nClientLoc = 118;
		public static string Service = "kr";

		public static string Developer = "KartRider 2023 by LAON";

		public SessionGroup(Socket clientSocket, Socket serverSocket)
		{
			this.Client = new ClientSession(this, clientSocket);
		}
	}
}