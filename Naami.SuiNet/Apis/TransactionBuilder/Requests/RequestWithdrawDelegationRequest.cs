﻿using System.Runtime.Serialization;
using Naami.SuiNet.Types;
using Naami.SuiNet.Types.Numerics;

namespace Naami.SuiNet.Apis.TransactionBuilder.Requests;

[DataContract]
public record RequestWithdrawDelegationRequest(
    [property: DataMember(Name = "signer")] SuiAddress Signer,
    [property: DataMember(Name = "delegation")] ObjectId Delegation,
    [property: DataMember(Name = "staked_sui")] ObjectId StakedSui,
    [property: DataMember(Name = "gas_budget")] U64 GasBudget
)
{
    [property: DataMember(Name = "gas_object")] 
    public ObjectId? GasObject { get; set; }
}