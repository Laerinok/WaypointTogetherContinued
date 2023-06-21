﻿using Vintagestory.API.Client;
using Vintagestory.API.Common;
using Vintagestory.API.Server;

[assembly: ModInfo(
	"WaypointTogether",
	Authors = new []{ "nulliel" } )]
namespace WaypointTogether;

public class Core : ModSystem
{
	public Client client;
	public Server server;

	public Patcher patcher;

	public override void Start(ICoreAPI api)
	{
		base.Start(api);

		patcher = new Patcher("WaypointTogether");
		patcher.PatchAll();
	}

	public override void StartClientSide(ICoreClientAPI api)
	{
		base.StartClientSide(api);

		client = new Client(api);
	}

	public override void StartServerSide(ICoreServerAPI api)
	{
		base.StartServerSide(api);

		server = new Server(api);
	}

	public override void Dispose()
	{
		patcher.Dispose();

		base.Dispose();
	}
}
