//SPDX-License-Identifier: MIT
pragma solidity >= 0.7.0 < 0.8.14;

contract ArrayOfFacts {
    string[] private facts;
    address private contractOwner;

    constructor() {
        contractOwner = msg.sender;
    }

    modifier onlyOwner() {
        require(msg.sender == contractOwner, "Only the contract owner can do this!");
        _;
    }

    function add(string memory newFact) public onlyOwner {
        facts.push(newFact);
    }

    function count() public view returns(uint256) {
        return facts.length;
    }

    function getFact(uint256 index) view public returns(string memory) {
           return facts[index];          
    }                                                                                                                                                                                                      
}

































































