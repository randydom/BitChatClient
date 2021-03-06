﻿/*
Technitium Bit Chat
Copyright (C) 2015  Shreyas Zare (shreyas@technitium.com)

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.

*/

using BitChatClient.Network.Connections;
using BitChatClient.Network.SecureChannel;
using System.Net;
using TechnitiumLibrary.Net.Proxy;
using TechnitiumLibrary.Security.Cryptography;

namespace BitChatClient.Network
{
    interface IBitChatNetworkManager
    {
        Connection MakeConnection(IPEndPoint peerEP);

        Connection MakeVirtualConnection(Connection viaConnection, IPEndPoint remotePeerEP);

        CertificateStore GetLocalCredentials();

        Certificate[] GetTrustedRootCertificates();

        SecureChannelCryptoOptionFlags GetSupportedCryptoOptions();

        int GetReNegotiateOnBytesSent();

        int GetReNegotiateAfterSeconds();

        bool CheckCertificateRevocationList();

        void RemoveNetwork(BitChatNetwork network);

        NetProxy GetProxy();
    }
}
