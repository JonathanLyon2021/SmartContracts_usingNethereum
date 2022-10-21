using System;
  using Nethereum.Web3;
  using Nethereum.Contracts;
  using Nethereum.Web3.Accounts;
  using Nethereum.Hex.HexTypes;
  
class Program {
  class ContractService {
    private readonly Web3 web3;
    private readonly Contract contract;
    private readonly Account account;
    
    private static readonly HexBigInteger GAS = new HexBigInteger(4600000);
    
    public ContractService(string provider, string contractAddress, string abi, string privateKey)
    {
      this.account = new Account(privateKey, 3);
      this.web3 = new Web3(account, provider);
      this.contract = web3.ETH.GetContract(abi, contractAddress);
    }
  }
}

