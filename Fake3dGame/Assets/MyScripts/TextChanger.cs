using Assets.Models;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using TMPro;
using UnityEngine;

public class TextChanger : MonoBehaviour
{
    TMP_Text text;
    async void Start()
    {
        HttpClient http = new HttpClient();
        HttpResponseMessage response = await http.GetAsync("https://tree.hostingasp.pl/api/cards/1");

        string content = await response.Content.ReadAsStringAsync();
        BaseModel<Card> model = JsonConvert.DeserializeObject<BaseModel<Card>>(content);
        var card = model.Data;

        text = GetComponent<TMP_Text>();
        text.text = card.Front;
    }
    void Update()
    {
        
    }
}
