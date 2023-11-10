using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesMy
{
    public  partial class Language

    {
        public  string Wellcome { get; protected set; }  = "";
        public string ChoseYourName { get; protected set; }  = "";
        public string DefaultName { get; protected set; } = "";
        public string DefaultRoomName { get; protected set; } = "";
        public string DefaultRoomDescriptions { get; protected set; } = "";
        public string ActionError { get; protected set; } = "";
        public string Go { get; protected set; } = "";
        public string GoError { get; protected set; } = "";
        public string WhatToDo { get; protected set; } = "";
        public string Quit { get; protected set; } =  "";
        public string NewRoom { get; protected set; }  = "";
        public string OldRoom { get; protected set; } = "";
        public string And { get; protected set; } = "";
        public string Comma { get; protected set; } = "";
        public string Space { get; protected set; } = "";
        public List<string> RooomDescriptions { get; protected set; }
        public string NoItem { get; protected set; } = "";
        public string Backpack { get; protected set; } = "";
        public string BackpackError { get; protected set; } = "";
        public string BackpackDescription { get; protected set; } = "";
        public string Chest { get; protected set; } = "";
        public string UnlockChest { get; protected set; } = "";
        public string Key { get; protected set; } = "";
        public string EmptyChest { get; protected set; } = "";
        public string ChestFound { get; protected set; } = ""; 
        public string Gold { get; protected set; } = "";
        public string Coin { get; protected set; } = "";
        public string Coins { get; protected set; } = "";
        public string Plural { get; protected set; } = "";
        public string Is { get; protected set; } = "";
        public string Are { get; protected set; } = "";
        public string TotalItems { get; protected set; } = "";
        public string Period { get; protected set; } = "";
        public string Take { get; protected set; } = "";
        public string TakeError { get; protected set; } = "";
        public string NotTaken { get; protected set; } = "";
        public string TookDescription { get; protected set; } = "";
        public string CantTakeDescription { get; protected set; } = "";
        public string Use { get; protected set; } = "";
        public string UseSuccess { get; protected set; } = "";
        public string UseError { get; protected set; } = "";
        
    }
}
