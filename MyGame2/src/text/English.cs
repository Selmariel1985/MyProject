using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesMy
{
    public class English : Language
    {

        public English()
        {
            ChoseYourName = "Как тебя зовут герой?";
            DefaultName = "Герой";
            Wellcome = "Приветствую  тебя ";
            DefaultRoomName = "Комната {0} ({1} , {2})";
            DefaultRoomDescriptions = " Ты в начальной комнате {0} с дверями на {1} ";
            ActionError = "Вы не можете сделать это";
            Go = "Идти";
            GoError = "Ты не можешь идти туда";
            WhatToDo = "Что ты хочешь сделать?";
            Quit = "quit";
            NewRoom = "Вы входите в новую комнату {0}.";
            OldRoom = "Вы вернулись в старую комнату {0}.";
            And = "и";
            Comma = ",";
            Space = " ";
            NoItem = "Нет предмета: {0}";
            Backpack = "Рюкзак";
            BackpackError = "Ошибка рюкзака";
            BackpackDescription = "Твой рюкзак содержит: {0}.";
            Chest = "сундук";
            UnlockChest = "Ты открыл сундук";
            Key = "ключ";
            EmptyChest = "Сундук пуст";
            ChestFound = "Сундук содержит {0}";
            Gold = "{0} золота {1}";
            Coin = "монета";
            Coins = "монет"; 
            Plural = "ы";
            Is = "есть";
            Are = "есть";
            TotalItems = "Здесь {0} {1} предмет{2} в комнате: ";
            Period = ".";
            Take = "Взять";
            TakeError = "Нечего брать";
            NotTaken = "Ты не можешь взять это";
            TookDescription = "Ты взял {0}";
            CantTakeDescription = "Ты не можешь взять {0}";
            Use = "использовать";
            UseSuccess = "Ты использовал {0}";
            UseError = "Ты не можешь использовать это";

            RooomDescriptions = new List<string>
            {
                "Нормальная",
                "Холодная",
                "Теплая",
                "Горчая",
                "Светлая",
                "Страшная",
                "Красивая",
                "Зеленая"
            };
        }
    }
}
