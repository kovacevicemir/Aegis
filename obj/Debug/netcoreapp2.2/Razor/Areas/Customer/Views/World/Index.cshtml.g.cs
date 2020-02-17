#pragma checksum "D:\C# Projects\Aegis-master\Aegis\Areas\Customer\Views\World\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8344f3af2d1e2035fd55210304f0e5fa964e02d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_World_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/World/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/World/Index.cshtml", typeof(AspNetCore.Areas_Customer_Views_World_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\C# Projects\Aegis-master\Aegis\Areas\Customer\Views\_ViewImports.cshtml"
using Aegis;

#line default
#line hidden
#line 2 "D:\C# Projects\Aegis-master\Aegis\Areas\Customer\Views\_ViewImports.cshtml"
using Aegis.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8344f3af2d1e2035fd55210304f0e5fa964e02d", @"/Areas/Customer/Views/World/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a910cc7144f637d51f60f5a3ca0c9fbd4c5f3533", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_World_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\C# Projects\Aegis-master\Aegis\Areas\Customer\Views\World\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(88, 33527, true);
            WriteLiteral(@"
<h1>WORLD!</h1>

<script type=""text/javascript"">
    var ctx = null;
    var gameMap = [
        0, 0, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
        0, 2, 4, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 2, 2, 0,
        0, 2, 3, 4, 4, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 2, 2, 0,
        0, 2, 3, 1, 4, 4, 1, 1, 2, 2, 2, 2, 1, 1, 2, 2, 2, 2, 2, 0,
        0, 8, 3, 1, 1, 4, 4, 1, 2, 3, 3, 2, 1, 1, 2, 1, 0, 0, 0, 0,
        0, 2, 2, 2, 2, 2, 2, 2, 2, 3, 3, 2, 2, 2, 2, 1, 1, 1, 1, 0,
        0, 2, 1, 1, 1, 2, 4, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 0,
        0, 2, 1, 1, 1, 2, 4, 1, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 0,
        0, 1, 1, 1, 1, 2, 4, 4, 4, 4, 4, 1, 1, 1, 2, 2, 2, 2, 1, 0,
        0, 1, 1, 1, 1, 2, 3, 2, 1, 1, 4, 1, 1, 1, 1, 3, 3, 2, 1, 0,
        0, 1, 2, 2, 2, 2, 1, 2, 1, 1, 4, 1, 1, 1, 1, 1, 3, 2, 1, 0,
        0, 1, 2, 3, 3, 2, 1, 2, 1, 1, 4, 4, 4, 4, 4, 4, 4, 2, 4, 4,
        0, 1, 2, 3, 3, 2, 1, 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 2, 1, 0,
        0, 1, 2, 3, 4, 2, 2, 2,");
            WriteLiteral(@" 1, 1, 1, 1, 1, 1, 1, 0, 1, 2, 1, 0,
        0, 3, 2, 3, 4, 4, 1, 2, 2, 2, 2, 2, 2, 2, 1, 0, 1, 2, 1, 0,
        0, 3, 2, 3, 4, 4, 3, 2, 1, 1, 1, 1, 1, 2, 1, 1, 1, 2, 3, 0,
        0, 3, 2, 3, 4, 1, 3, 2, 1, 3, 1, 1, 1, 2, 1, 1, 1, 2, 3, 0,
        0, 1, 2, 2, 2, 2, 2, 2, 3, 3, 3, 1, 1, 2, 2, 2, 2, 2, 3, 0,
        0, 1, 1, 1, 1, 1, 1, 3, 3, 3, 3, 3, 1, 1, 1, 1, 1, 1, 4, 0,
        0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0
    ];
    var tileW = 40, tileH = 40;
    var mapW = 20, mapH = 20;
    var currentSecond = 0, frameCount = 0, framesLastSecond = 0, lastFrameTime = 0;

    var tileset = null, tilesetURL = ""../images/tileset.png"", tilesetLoaded = false;

    var disableMove = false;

    var r1, r2, r3, r4, r5, r6, r7, r8, r9, r10;

    //napraviti array i da mu je lenght kolko je i room count i onda na osnovu killa ubacit rc[vrijeme] kontas
    var r1t;

    var r1tAoE;

    var floorTypes = {
        solid: 0,
        path: 1,
        water: 2,
        room1: ");
            WriteLiteral(@"3,
        room2: 4,
        room3: 5,
        room4: 6,
        room5: 7,
        room6: 8,
        room7: 9,
        room8: 10,
        room9: 11,
        room10: 12
    };
    var tileTypes = {
        0: { colour: ""#685b48"", floor: floorTypes.solid, sprite: [{ x: 0, y: 0, w: 40, h: 40 }] },
        1: { colour: ""#5aa457"", floor: floorTypes.path, sprite: [{ x: 40, y: 0, w: 40, h: 40 }] },
        2: { colour: ""#e8bd7a"", floor: floorTypes.path, sprite: [{ x: 80, y: 0, w: 40, h: 40 }] },
        3: { colour: ""#286625"", floor: floorTypes.solid, sprite: [{ x: 120, y: 0, w: 40, h: 40 }] },
        4: { colour: ""#678fd9"", floor: floorTypes.water, sprite: [{ x: 160, y: 0, w: 40, h: 40 }] },
        5: { colour: ""#0000ff"", floor: floorTypes.room1, sprite: [{ x: 160, y: 0, w: 40, h: 40 }] },
        6: { colour: ""#0000ff"", floor: floorTypes.room2, sprite: [{ x: 160, y: 0, w: 40, h: 40 }] },
        7: { colour: ""#0000ff"", floor: floorTypes.room3, sprite: [{ x: 160, y: 0, w: 40, h: 40 }] },
     ");
            WriteLiteral(@"   8: { colour: ""#0000ff"", floor: floorTypes.room4, sprite: [{ x: 160, y: 0, w: 40, h: 40 }] },
        9: { colour: ""#0000ff"", floor: floorTypes.room5, sprite: [{ x: 160, y: 0, w: 40, h: 40 }] },
        10: { colour: ""#0000ff"", floor: floorTypes.room6, sprite: [{ x: 160, y: 0, w: 40, h: 40 }] },
        11: { colour: ""#0000ff"", floor: floorTypes.room7, sprite: [{ x: 160, y: 0, w: 40, h: 40 }] },
        12: { colour: ""#0000ff"", floor: floorTypes.room8, sprite: [{ x: 160, y: 0, w: 40, h: 40 }] },
        13: { colour: ""#0000ff"", floor: floorTypes.room9, sprite: [{ x: 160, y: 0, w: 40, h: 40 }] },
        14: { colour: ""#0000ff"", floor: floorTypes.room10, sprite: [{ x: 160, y: 0, w: 40, h: 40 }] }
    };

    var directions = {
        up: 0,
        right: 1,
        down: 2,
        left: 3
    };

    var keysDown = {
        65: false,
        87: false,
        68: false,
        83: false
    };

    var viewport = {
        screen: [0, 0],
        startTile: [0, 0],
        en");
            WriteLiteral(@"dTile: [0, 0],
        offset: [0, 0],
        update: function (px, py) {
            this.offset[0] = Math.floor((this.screen[0] / 2) - px);
            this.offset[1] = Math.floor((this.screen[1] / 2) - py);

            var tile = [Math.floor(px / tileW), Math.floor(py / tileH)];

            this.startTile[0] = tile[0] - 1 - Math.ceil((this.screen[0] / 2) / tileW);
            this.startTile[1] = tile[1] - 1 - Math.ceil((this.screen[1] / 2) / tileH);

            if (this.startTile[0] < 0) { this.startTile[0] = 0; }
            if (this.startTile[1] < 0) { this.startTile[1] = 0; }

            this.endTile[0] = tile[0] + 1 + Math.ceil((this.screen[0] / 2) / tileW);
            this.endTile[1] = tile[1] + 1 + Math.ceil((this.screen[1] / 2) / tileH);

            if (this.endTile[0] >= mapW) { this.endTile[0] = mapW - 1; }
            if (this.endTile[1] >= mapH) { this.endTile[1] = mapH - 1; }
        }
    };

    var player = new Character();

    function Character() {
        ");
            WriteLiteral(@"this.tileFrom = [1, 1];
        this.tileTo = [1, 1];
        this.timeMoved = 0;
        this.dimensions = [30, 30];
        this.position = [45, 45];
        this.delayMove = 500;

        this.direction = directions.up;
        this.sprites = {};
        this.sprites[directions.up] = [{ x: 0, y: 120, w: 30, h: 30 }];
        this.sprites[directions.right] = [{ x: 0, y: 150, w: 30, h: 30 }];
        this.sprites[directions.down] = [{ x: 0, y: 180, w: 30, h: 30 }];
        this.sprites[directions.left] = [{ x: 0, y: 210, w: 30, h: 30 }];
    }

    Character.prototype.placeAt = function (x, y) {
        this.tileFrom = [x, y];
        this.tileTo = [x, y];
        this.position = [((tileW * x) + ((tileW - this.dimensions[0]) / 2)),
        ((tileH * y) + ((tileH - this.dimensions[1]) / 2))];
    };

    Character.prototype.processMovement = function (t) {
        if (this.tileFrom[0] == this.tileTo[0] && this.tileFrom[1] == this.tileTo[1]) { return false; }

        if ((t - this.tim");
            WriteLiteral(@"eMoved) >= this.delayMove) {
            this.placeAt(this.tileTo[0], this.tileTo[1]);
        }
        else {
            this.position[0] = (this.tileFrom[0] * tileW) + ((tileW - this.dimensions[0]) / 2);
            this.position[1] = (this.tileFrom[1] * tileH) + ((tileH - this.dimensions[1]) / 2);

            if (this.tileTo[0] != this.tileFrom[0]) {
                var diff = (tileW / this.delayMove) * (t - this.timeMoved);
                this.position[0] += (this.tileTo[0] < this.tileFrom[0] ? 0 - diff : diff);
            }
            if (this.tileTo[1] != this.tileFrom[1]) {
                var diff = (tileH / this.delayMove) * (t - this.timeMoved);
                this.position[1] += (this.tileTo[1] < this.tileFrom[1] ? 0 - diff : diff);
            }

            this.position[0] = Math.round(this.position[0]);
            this.position[1] = Math.round(this.position[1]);
        }

        return true;
    }


    Character.prototype.canMoveTo = function (x, y) {
       ");
            WriteLiteral(@" if (x < 0 || x >= mapW || y < 0 || y >= mapH) { return false; }

        if (

            (tileTypes[gameMap[toIndex(x, y)]].floor == floorTypes.room1 ||
                tileTypes[gameMap[toIndex(x, y)]].floor == floorTypes.room2 ||
                tileTypes[gameMap[toIndex(x, y)]].floor == floorTypes.room3 ||
                tileTypes[gameMap[toIndex(x, y)]].floor == floorTypes.room4 ||
                tileTypes[gameMap[toIndex(x, y)]].floor == floorTypes.room5 ||
                tileTypes[gameMap[toIndex(x, y)]].floor == floorTypes.room6 ||
                tileTypes[gameMap[toIndex(x, y)]].floor == floorTypes.room7 ||
                tileTypes[gameMap[toIndex(x, y)]].floor == floorTypes.room8 ||
                tileTypes[gameMap[toIndex(x, y)]].floor == floorTypes.room9 ||
                tileTypes[gameMap[toIndex(x, y)]].floor == floorTypes.room10)
            &&
            disableMove == false

        ) {

            var interval = 1000;


            if (r1 != null) {

      ");
            WriteLiteral(@"          //Treba ubacit da se disable click na ostala dugmad ako je attack u toku...

                console.log(""######"");
                console.log(r1t.length + ' r1t length');
                console.log(r1t[0] + ' r1t[0]');
                console.log(r1t[1] + ' r1t[1]');
                console.log(r1t[2] + ' r1t[2]');
                console.log(""######"");

                for (x = r1t.length; x > 0; x--) {
                    if (r1t[x - 1] != 0) {
                        var tmp = new Date() - r1t[x - 1];
                        var tmpRoomSpawnTime = r1.room.respawnTime;
                        var tmpRoomSpawnTimeArray = tmpRoomSpawnTime.split('/');
                        var tmpRoomSpawnTimeFinal = parseInt(tmpRoomSpawnTimeArray[0], 10);

                        if (tmp > (tmpRoomSpawnTimeFinal * 1000)) {
                            var mcTemp3 = r1.room.monsterCount;
                            var mcTempArray3 = mcTemp3.split('/');

                            mcTempArray");
            WriteLiteral(@"3[0] = parseInt(mcTempArray3[0], 10) + 1;

                            r1.room.monsterCount = mcTempArray3.join(""/"");
                            console.log(r1.room.monsterCount + ' updated monster count');
                            r1t[x - 1] = 0;
                            console.log(x + 'this is x');
                        }
                    }
                }


                $('#RoomPicture').empty().append('<img style=""max-width:250px; margin-top:5px; margin-bottom:5px;"" src=""' + r1.room.roomPicture + '"">');

                r1.monsterList.forEach(function (item) {
                    var mcTemp1 = r1.room.monsterCount;
                    var mcTempArray1 = mcTemp1.split('/');
                    var tempMonsterCount = mcTempArray1[0];
                    console.log(tempMonsterCount + ' this is how many monsters we have now');


                    for (im = tempMonsterCount; im > 0; im--) {
                        $('#Monsters').append('<button id=""'+im+'"" enabled styl");
            WriteLiteral(@"e=""display:block; margin-bottom:5px;"" class=""singleMonster"">' + item.name + "" ["" + item.level + ""]"" + "" "" + '<img style=""max-width:50px; max-height:40px;"" src=""' + item.picture + '"">' + '</button>');

                        $('.singleMonster').off().one('click', function () {
                            disableMove = true;
                            $("".singleMonster"").prop('disabled', true);
                            $('#BattleResult').empty();


                            $.ajax({
                                url: 'https://localhost:44337/Customer/Monster/AttackMonster?id=' + r1.room.id,
                                type: 'GET',
                                success: function (data1) {
                                    console.log(data1);
                                    var playerAttacks = data1.playerAttacks;
                                    var monsterAttacks = data1.monsterAttacks;
                                    var playerHpLog = data1.playerCurrentHpLog;
      ");
            WriteLiteral(@"                              var monsterHpLog = data1.monsterCurrentHpLog;
                                    var i = 0;
                                    playerAttacks.forEach(function (element, index) {
                                        setTimeout(function () {
                                            $('#BattleLog').empty();
                                            var tempElement = element;
                                            if (tempElement == 0) {
                                                tempElement = ""Block!"";
                                            }

                                            if (tempElement != ""Block!"") {
                                                if (tempElement < 0) {
                                                    tempElement = (tempElement * -1) + "" CRIT!""
                                                }
                                            }

                                            $('#BattleLog').append(""");
            WriteLiteral(@"<p style='color:green;'>"" + tempElement + ""</p>"");

                                            var temptemp = monsterAttacks[i];
                                            if (temptemp == 0) {
                                                temptemp = ""Block!"";
                                            }

                                            if (temptemp != ""Block!"") {
                                                if (temptemp < 0) {
                                                    temptemp = ""Miss!"";
                                                }
                                            }

                                            $('#BattleLog1').empty();
                                            $('#BattleLog1').append(""<p style='color:red;'>"" + temptemp + ""</p>"");


                                            i++;

                                            if (monsterHpLog[i] < 0 || playerHpLog[i] < 0) {
                                                if (mo");
            WriteLiteral(@"nsterHpLog[i] < 0) {
                                                    $('#BattleLog1').empty();
                                                    $('#BattleLog').empty();
                                                    $('#BattleResult').append(""<p style='color:yellow;'>VICTORY!: </p><br/>"");
                                                    $('#BattleResult').append(""<p style='color:yellow;'>EXP: "" + r1.monsterList[0].exp + ""</p>"");
                                                    $('#BattleResult').append(""<p style='color:yellow;'>GOLD : "" + r1.monsterList[0].goldPerKill + ""</p>"");



                                                    console.log(r1.room.monsterCount);

                                                    var mcTemp = r1.room.monsterCount;
                                                    var mcTempArray = mcTemp.split('/');
                                                    console.log(mcTempArray);

                                                    r1t[mc");
            WriteLiteral(@"TempArray.length - mcTempArray[0]] = new Date();


                                                    console.log(r1t[mcTempArray.length - mcTempArray[0]]) + 'ono';


                                                    mcTempArray[0] = mcTempArray[0] - 1;
                                                    console.log(mcTempArray[0]);

                                                    mcTemp = mcTempArray.join(""/"");
                                                    console.log(""breakkk"");
                                                    console.log(mcTemp);

                                                    r1.room.monsterCount = mcTemp;
                                                    disableMove = false;
                                                    $("".singleMonster"").prop('disabled', false);

                                                    alert(im);
                                                    alert('upMethod');
                                            ");
            WriteLiteral(@"        document.getElementById(im).style.display = ""none"";

                                                    //after spawn time +1 to that monster count...


                                                } else {
                                                    $('#BattleLog1').empty();
                                                    $('#BattleLog').empty();
                                                    $('#BattleResult').append(""<p style='color:yellow;'>LOSE: </p>"");

                                                    $("".singleMonster"").prop('disabled', false);
                                                }
                                            }



                                        }, index * interval);

                                    });

                                }
                            });
                            //end of ajax call

                        });
                    }
                    //end of for loop

");
            WriteLiteral(@"


                });

                { return true; }





            } else {

                $.ajax({
                    url: '/Customer/Monster/GetRoom/' + tileTypes[gameMap[toIndex(x, y)]].floor,
                    type: 'GET',
                    success: function (data) {
                        $('#Monsters').empty();
                        console.log(data);
                        console.log(data.room.monsterList + ' monster count');
                        console.log(data.room);

                        $('#RoomPicture').empty().append('<img style=""max-width:250px; margin-top:5px; margin-bottom:5px;"" src=""' + data.room.roomPicture + '"">');


                        var mcTemp = data.room.monsterCount;
                        var mcTempArray = mcTemp.split('/');
                        var mcTempCount = mcTempArray[0];


                        //Za svakog monstera dodajemo broj monstera u toj sobi
                        data.monsterList.forEach(function (ite");
            WriteLiteral(@"m) {

                            for (im = mcTempCount; im > 0; im--) {
                                //dodajemo monster dugme, sliku, lvl...
                                $('#Monsters').append('<button id=""'+im+'"" enabled style=""display:block; margin-bottom:5px;"" class=""singleMonster"">' + item.name + "" ["" + item.level + ""]"" + "" "" + '<img style=""max-width:50px; max-height:40px;"" src=""' + item.picture + '"">' + '</button>');

                                //dodajemo event onClick
                                $('.singleMonster').off().one('click', function () {

                                    //disableujemo ostala dugmad, onemogucavamo kretanje, brisemo battle result od prethodne borbe
                                    $("".singleMonster"").prop('disabled', true);
                                    disableMove = true;
                                    var xxx = im;
                                    $('#BattleResult').empty();


                                    $.ajax({
   ");
            WriteLiteral(@"                                     url: 'https://localhost:44337/Customer/Monster/AttackMonster?id=' + data.room.id,
                                        type: 'GET',
                                        success: function (data1) {
                                            console.log(data1);
                                            var playerAttacks = data1.playerAttacks;
                                            var monsterAttacks = data1.monsterAttacks;
                                            var playerHpLog = data1.playerCurrentHpLog;
                                            var monsterHpLog = data1.monsterCurrentHpLog;
                                            var i = 0;

                                            playerAttacks.forEach(function (element, index) {
                                                setTimeout(function () {
                                                    $('#BattleLog').empty();
                                                    var t");
            WriteLiteral(@"empElement = element;
                                                    if (tempElement == 0) {
                                                        tempElement = ""Block!"";
                                                    }

                                                    if (tempElement != ""Block!"") {
                                                        if (tempElement < 0) {
                                                            tempElement = (tempElement * -1) + "" CRIT!""
                                                        }
                                                    }

                                                    $('#BattleLog').append(""<p style='color:green;'>"" + tempElement + ""</p>"");

                                                    var temptemp = monsterAttacks[i];
                                                    if (temptemp == 0) {
                                                        temptemp = ""Block!"";
                                ");
            WriteLiteral(@"                    }

                                                    if (temptemp != ""Block!"") {
                                                        if (temptemp < 0) {
                                                            temptemp = ""Miss!"";
                                                        }
                                                    }

                                                    $('#BattleLog1').empty();
                                                    $('#BattleLog1').append(""<p style='color:red;'>"" + temptemp + ""</p>"");


                                                    i++;

                                                    if (monsterHpLog[i] < 0 || playerHpLog[i] < 0) {
                                                        if (monsterHpLog[i] < 0) {

                                                            //Award player with item ?
                                                            var randomNumber = Math.floor(Math.random");
            WriteLiteral(@"() * 101);
                                                            var isDrop = Boolean(randomNumber < data.monsterList[0].drop1Chance);
                                                            var tempItemName;

                                                            if (isDrop) {
                                                                var tempDropItemList = data.monsterList[0].dropList;
                                                                var tempDropItemIdArray = tempDropItemList.split('/');
                                                                var tempDropItemId = tempDropItemIdArray[0];

                                                                $.ajax({
                                                                    url: 'https://localhost:44337/Customer/Item/DropItemToPlayer?itemid=' + tempDropItemId,
                                                                    type: 'POST',
                                                             ");
            WriteLiteral(@"       success: function (DropItemData) {
                                                                        console.log('droped item name: ')
                                                                        console.log(DropItemData);
                                                                        tempItemName = DropItemData;
                                                                   }
                                                                });
                                                            }

                                                            //Award player with: exp, gold, mob kill count
                                                            $.ajax({
                                                                url: 'https://localhost:44337/Customer/PlayerProfile/AwardPlayerOnKill?gold=' + data.monsterList[0].goldPerKill + '&exp=' + data.monsterList[0].exp,
                                                                type: 'POST'");
            WriteLiteral(@",
                                                                success: function (AwardExpData) {
                                                                    console.log('exp awarded: ' + data.monsterList[0].exp);
                                                               }
                                                            });

                                                            $('#BattleLog1').empty();
                                                            $('#BattleLog').empty();
                                                            $('#BattleResult').append(""<p style='color:yellow;'>VICTORY!: </p><br/>"");
                                                            $('#BattleResult').append(""<p style='color:yellow;'>EXP: "" + data.monsterList[0].exp + ""</p>"");
                                                            $('#BattleResult').append(""<p style='color:yellow;'>GOLD : "" + data.monsterList[0].goldPerKill + ""</p>"");
                              ");
            WriteLiteral(@"                              if (isDrop) {$('#BattleResult').append(""<p style='color:yellow;'>DROP : "" + tempItemName + ""</p>"");}
                                                            

                                                            console.log(data.room.monsterCount);
                                                            console.log(mcTempArray);

                                                            r1t = new Array(mcTempArray.length);
                                                            r1t[mcTempArray.length - mcTempArray[0]] = new Date();
                                                            console.log(r1t[mcTempArray.length - mcTempArray[0]]) + 'ovo';

                                                            mcTempArray[0] = mcTempArray[0] - 1;
                                                            console.log(mcTempArray[0]);

                                                            mcTemp = mcTempArray.join(""/"");
                  ");
            WriteLiteral(@"                                          console.log(""breakkk"");
                                                            console.log(mcTemp);

                                                            data.room.monsterCount = mcTemp;

                                                            r1 = data;

                                                            console.log(r1t);
                                                            //after spawn time +1 to that monster count...
                                                            disableMove = false;
                                                            $("".singleMonster"").prop('disabled', false);

                                                            document.getElementById(xxx).style.display = ""none"";


                                                        } else {
                                                            $('#BattleLog1').empty();
                                                       ");
            WriteLiteral(@"     $('#BattleLog').empty();
                                                            $('#BattleResult').append(""<p style='color:yellow;'>LOSE: </p>"");
                                                        }
                                                    }



                                                }, index * interval);

                                            });

                                        }
                                    });
                                    //end of ajax call

                                });
                            }
                            //end of for loop

                        });

                    }
                });

            }










        }
        else {
            $('#RoomPicture').empty();
            $('#Monsters').empty();
            $('#BattleResult').empty();
            console.log(r1t);
        }

        if ((tileTypes[gameMap[toIndex(x, y)]].floor == floorT");
            WriteLiteral(@"ypes.path ||
            tileTypes[gameMap[toIndex(x, y)]].floor == floorTypes.room1 ||
            tileTypes[gameMap[toIndex(x, y)]].floor == floorTypes.room2 ||
            tileTypes[gameMap[toIndex(x, y)]].floor == floorTypes.room3 ||
            tileTypes[gameMap[toIndex(x, y)]].floor == floorTypes.room4 ||
            tileTypes[gameMap[toIndex(x, y)]].floor == floorTypes.room5 ||
            tileTypes[gameMap[toIndex(x, y)]].floor == floorTypes.room6 ||
            tileTypes[gameMap[toIndex(x, y)]].floor == floorTypes.room7 ||
            tileTypes[gameMap[toIndex(x, y)]].floor == floorTypes.room8 ||
            tileTypes[gameMap[toIndex(x, y)]].floor == floorTypes.room9 ||
            tileTypes[gameMap[toIndex(x, y)]].floor == floorTypes.room10)
            &&
            disableMove == false
        ) { return true; }



        return false;

    };
    Character.prototype.canMoveUp = function () { return this.canMoveTo(this.tileFrom[0], this.tileFrom[1] - 1); };
    Character.pro");
            WriteLiteral(@"totype.canMoveDown = function () { return this.canMoveTo(this.tileFrom[0], this.tileFrom[1] + 1); };
    Character.prototype.canMoveLeft = function () { return this.canMoveTo(this.tileFrom[0] - 1, this.tileFrom[1]); };
    Character.prototype.canMoveRight = function () { return this.canMoveTo(this.tileFrom[0] + 1, this.tileFrom[1]); };

    Character.prototype.moveLeft = function (t) { this.tileTo[0] -= 1; this.timeMoved = t; this.direction = directions.left; };
    Character.prototype.moveRight = function (t) { this.tileTo[0] += 1; this.timeMoved = t; this.direction = directions.right; };
    Character.prototype.moveUp = function (t) { this.tileTo[1] -= 1; this.timeMoved = t; this.direction = directions.up; };
    Character.prototype.moveDown = function (t) { this.tileTo[1] += 1; this.timeMoved = t; this.direction = directions.down; };

    function toIndex(x, y) {
        return ((y * mapW) + x);
    }

    window.onload = function () {
        ctx = document.getElementById('game').getContext(");
            WriteLiteral(@"""2d"");
        requestAnimationFrame(drawGame);
        ctx.font = ""bold 10pt sans-serif"";

        window.addEventListener(""keydown"", function (e) {
            if (e.keyCode >= 65 && e.keyCode <= 87) { keysDown[e.keyCode] = true; }
        });
        window.addEventListener(""keyup"", function (e) {
            if (e.keyCode >= 65 && e.keyCode <= 87) { keysDown[e.keyCode] = false; }
        });

        viewport.screen = [document.getElementById('game').width,
        document.getElementById('game').height];

        tileset = new Image();
        tileset.onerror = function () {
            ctx = null;
            alert(""Failed loading tileset."");
        };
        tileset.onload = function () { tilesetLoaded = true; };
        tileset.src = tilesetURL;
    };

    function drawGame() {
        if (ctx == null) { return; }
        if (!tilesetLoaded) { requestAnimationFrame(drawGame); return; }

        var currentFrameTime = Date.now();
        var timeElapsed = currentFrameTime");
            WriteLiteral(@" - lastFrameTime;

        var sec = Math.floor(Date.now() / 1000);
        if (sec != currentSecond) {
            currentSecond = sec;
            framesLastSecond = frameCount;
            frameCount = 1;
        }
        else { frameCount++; }

        if (!player.processMovement(currentFrameTime)) {
            if (keysDown[87] && player.canMoveUp() && disableMove == false) { player.moveUp(currentFrameTime); }
            else if (keysDown[83] && player.canMoveDown() && disableMove == false) { player.moveDown(currentFrameTime); }
            else if (keysDown[65] && player.canMoveLeft() && disableMove == false) { player.moveLeft(currentFrameTime); }
            else if (keysDown[68] && player.canMoveRight() && disableMove == false) { player.moveRight(currentFrameTime); }
        }

        viewport.update(player.position[0] + (player.dimensions[0] / 2),
            player.position[1] + (player.dimensions[1] / 2));

        ctx.fillStyle = ""#000000"";
        ctx.fillRect(0, 0, viewpo");
            WriteLiteral(@"rt.screen[0], viewport.screen[1]);

        for (var y = viewport.startTile[1]; y <= viewport.endTile[1]; ++y) {
            for (var x = viewport.startTile[0]; x <= viewport.endTile[0]; ++x) {
                var tile = tileTypes[gameMap[toIndex(x, y)]];
                ctx.drawImage(tileset,
                    tile.sprite[0].x, tile.sprite[0].y, tile.sprite[0].w, tile.sprite[0].h,
                    viewport.offset[0] + (x * tileW), viewport.offset[1] + (y * tileH),
                    tileW, tileH);
            }
        }

        var sprite = player.sprites[player.direction];
        ctx.drawImage(tileset,
            sprite[0].x, sprite[0].y, sprite[0].w, sprite[0].h,
            viewport.offset[0] + player.position[0], viewport.offset[1] + player.position[1],
            player.dimensions[0], player.dimensions[1]);

        ctx.fillStyle = ""#ff0000"";
        ctx.fillText(""FPS: "" + framesLastSecond, 10, 20);

        lastFrameTime = currentFrameTime;
        requestAnimationFrame");
            WriteLiteral(@"(drawGame);
    }


</script>

<row class=""d-flex bg-dark"">
    <canvas class=""shadow-sm p-1 m-1 mb-5 bg-warning rounded"" id=""game"" width=""400"" height=""400""></canvas>
    <div id=""RoomInfo"" class=""bg-dark ml-2 text-white"" style=""width:400px; height:400px;"">
        <div id=""RoomPicture""></div>
        <div id=""Monsters""></div>
        <div id=""BattleLog""></div>
        <div id=""BattleLog1""></div>
        <div id=""BattleResult""></div>
    </div>
</row>

<row class=""d-flex bg-dark"">
    <div class=""pl-3 pb-3 pr-3 text-white-50"" style=""width:400px; height:100px;"">
        <strong>Movement - |W| |A| |S| |D|</strong><br />
        <strong>Skills&nbsp;  |Q-AoE|  &nbsp;  |SPACE|   &nbsp;   |R-Single|</strong><br />
    </div>
</row>
");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
