//напишите программу, которая из имеющегося массива строк
//  формирует массив из строк, длина которых меньше либо равна 3

    string[] stringArray = {"hello", "2", "world", ":-)"};
    string[] newArray = {};

    Array.Resize(ref newArray, stringArray.Length);

    for (int i=0; i < stringArray.Length; i++) {
      if (stringArray[i].Length <= 3) {
        newArray[i] = stringArray[i];
      }
    }

    for (int i=0; i < newArray.Length; i++) {
      Console.WriteLine(newArray[i]);
    }
    