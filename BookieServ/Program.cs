using System;
using System.Collections.Generic;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace BookieServ
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      var wssv = new WebSocketServer("ws://192.99.109.121:3000");
      wssv.AddWebSocketService<BookieService>("/");
      wssv.Start();
      Console.ReadKey(true);
      wssv.Stop();
    }
  }
}