﻿using System;
using Konata.Core.Events.Model;
using Konata.Core.Packets;
using Konata.Core.Packets.Oidb.Model;
using Konata.Core.Attributes;
using Konata.Core.Common;

// ReSharper disable UnusedType.Global
// ReSharper disable RedundantAssignment

namespace Konata.Core.Components.Services.OidbSvc;

[EventSubscribe(typeof(GroupPromoteAdminEvent))]
[Service("OidbSvc.0x55c_1", PacketType.TypeB, AuthFlag.D2Authentication, SequenceMode.Managed)]
internal class Oidb0x55c_1 : BaseService<GroupPromoteAdminEvent>
{
    protected override bool Parse(SSOFrame input, BotKeyStore keystore,
        out GroupPromoteAdminEvent output)
    {
        throw new NotImplementedException();
    }

    protected override bool Build(int sequence, GroupPromoteAdminEvent input,
        BotKeyStore keystore, BotDevice device, ref PacketBase output)
    {
        output = new OidbCmd0x55c_1(input.GroupUin, input.MemberUin, input.ToggleType);
        return true;
    }
}
