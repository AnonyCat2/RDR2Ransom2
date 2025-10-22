using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RDR2;
using RDR2.Native;
using RDR2.Math;
using RDR2.UI;
using System.IO;
using RDR2.NaturalMotion;
using UI = RDR2.UI.Screen;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

using System.Dynamic;
using System.Security.Policy;
using System.CodeDom;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.AccessControl;
using RDR2Ransom_V2;
using System.Net.Http.Headers;
using static System.Windows.Forms.AxHost;

namespace RDR2Ransom_V2
{
    public class RDR2Ransom_V2 : Script
    {

        bool deathactive = true;

        int dai = 0;
        Blip loot1blip;
        Blip loot2blip;

        Prop chestprop1;
        Ped odrisped;


        PointF fas = new PointF(61.59945f, 79.10033f);

        int omdai = 0;
        bool oncea;

        //     Prop wallprop1;
        PointF pointf = new PointF(80.85066f, 85.50087f);
        SizeF sizef = new SizeF(290f, 75f);

        Blip obectiveblip;

        bool mainactive = true;


        int holdcheck = 0;

        bool m8t = true;
        int dasda = 0;
        int thescen;

        bool sprintb = false;
        bool doubletapped = false;
        int waitresetdoubletap = 0;

        //   Vector3 PedBPos;
        //  Vector3 PedCPos;
          IniFile MyIni = new IniFile("scripts\\RDR2Ransom.ini");
        //  ini
        bool lastusepos;
        RDR2.UI.TextElement Text1;
        RDR2.UI.TextElement Text2;
        RDR2.UI.TextElement Text3;
        RDR2.UI.TextElement Text4;
        RDR2.UI.TextElement Text5;
        RDR2.UI.TextElement Text6;
        RDR2.UI.TextElement Text7;
        RDR2.UI.TextElement Text8;
        RDR2.UI.TextElement Text9;
        RDR2.UI.Sprite boxprite;
        RDR2.UI.Sprite boxpritemicro;
        RDR2.UI.Sprite boxpritesel;
        float pointx = 20;
        float pointy = 20;

        int menus = -21;


        int mai = -1310;
        //   int possetint = -6411;
        int possetint = -645611;
        bool spawnhogtiedsetup = false;
        string spawnmodelhash = "cs_mp_bonnie";
        Blip tblip;
        int selsection = 0;
        bool setupinv = false;
        int spawnoutfit = 0;
        uint spawnweapon = 0;
        Vector3 spawnsetuppos;
        int followtrigs = 0;
        string setscenario;
        bool movetoggled = false;
        string invibc = "false";
        string usingpos = "false";
        float plposx;
        float plposy;
        float plposz;
        float plheading;
        float hposx;
        float hposy;
        float hposz;
        float hheading;
        int poutfit;
        string usenewmod = "false";
        string newmod = "false";
        int ma = 0;
        int timerb;
        Ped badped;
        List<Ped> pedlist = new List<Ped>();
        List<Ped> goodlist = new List<Ped>();
        Ped goodped;
        int efirstdeathindex;
        Ped temped;
        int spawnsgood;
        Ped temped2;
        int deletere = -2;

        int deleterf = -2;
        List<Ped> ewaitinglist = new List<Ped>();
        List<Ped> edeadlist = new List<Ped>();
        List<Ped> fdeadlist = new List<Ped>();
        int deleteftime;
        int deleteetime;
        List<Ped> fwaitinglist = new List<Ped>();
        int nextparte;
        int nextpartf;
        Ped otempede;
        Ped otempedf;
        bool badstage = false;
        bool goodstage = false;
        int nolaw = -1;
        int toaddtimegood = 0;
        int toaddtimebad = 0;
        int gt = -1;
        Ped oge;
        bool deadlistinit = false;
        List<Ped> ogelist = new List<Ped>();
        int ogetime;
        int bt = -1;
        Ped oge2;
        bool deadlistinit2 = false;
        List<Ped> ogelist2 = new List<Ped>();
        int ogetime2;
        int constrem = -1;
        int listlength;
        int listlength2;
        int rand1;
        int rand2;
        int ogelistcount;
        int ogelistcount2;

        int atdlibad = -1;
        int atdli = -1;
        int ndl = -1;
        int newtime1;
        int ndl2 = -1;
        int newtime2;

        List<Ped> newdeadlist2 = new List<Ped>();
        List<Ped> newdeadlist = new List<Ped>();
        Ped newtemped;
        Ped newtemped2;
        Ped newgooddeadtemped;
        Ped newbaddeadtemped;
        bool despawnersenabled;
        int lastenemyindex;
        int lastenemyindex2;
        List<Ped> enemdeadlist = new List<Ped>();
        Ped enem1;
        Ped enem2;
        Ped enem3;
        Ped enem4;
        Ped enem5;
        Ped enem6;
        Ped enem7;
        Ped enem8;
        Ped enem9;
        Ped enem10;
        Ped enem11;
        Ped enem12;
        Ped enem13;
        Ped enem14;
        Ped enem15;
        Ped enem16;
        Ped fre1;
        Ped fre2;
        Ped fre3;
        Ped fre4;
        Ped fre5;
        Ped fre6;
        Ped fre7;
        Ped fre8;
        Ped fre9;
        Ped fre10;
        Ped fre11;
        Ped fre12;
        Ped fre13;
        Ped fre14;
        Ped fre15;
        int genwarswitch = -1;
        Vector3 spawn1;
        Vector3 spawn2;
        Vector3 spawn3;
        Vector3 spawn4;
        int delebad = -1;
        int delegood = -1;
        bool counterstartedbad;
        bool counterstartedgood;
        List<Prop> lootlist = new List<Prop>();
        List<Prop> proplist = new List<Prop>();
        int lastpropindex;
        List<Prop> constproplist = new List<Prop>();
        List<Blip> bliplist = new List<Blip>();
        List<Prop> chestlist = new List<Prop>();
        int lastblipindex;

        int gametype = -1;//0=TMD 1=Zones 2=Assault 3=Campaign
        int finishtype = -1;//0=Best Of 1=Endless 2=Endless No Breaks
        int entrytype = -1;//0=Teleport mid battle 1=Teleport before battle 2=Teleport Outside mid battle 3=Teleport outside pre-battle 4=Travel to battle 5=Travel to pre-battle
        int entrysubtype = -1;// Depending on the map different area
        int maptype = -1;//0=Old Battle Field 1=Snowy Avalanche 5=IwoJima

        float headingemen;
        float headingfriend;
        int randomnazi = -1;
        string spawnww2props;
        List<Ped> gooddeadlist = new List<Ped>();
        int spoints = -1;
        int menutriggers = -1;
        Vector3 menutrigzone;
        int battlemenu = -1;
        List<string> enemweapons = new List<string>();

        List<string> frienweapons = new List<string>();
        Prop temprop;
        Prop chest1;
        Prop chest2;
        Prop chest3;
        Prop chest4;
        int spawntowander = -1;
        Blip yourbaseblip;
        Blip enembaseblip;
        bool battleactive;
        int takeovertimer;
        Vector3 enlistmentpos;
        Vector3 enlistmenthorsepos;
        bool debugwritepos = true;
        int dwp = 1;
        string casww;
        int chestsfiller = -1;
        int fillchesttimer;
        bool fadeoutsenabled = true;
        bool debugdisablesubs = false;
        Blip cbaseblip;
        bool af = false;
        bool acon = false;
        bool bcon = false;
        bool ccon = false;
        bool countstarted = false;
        int attackrandtimer;
        int nextattackarea;
        bool ongoingattack = false;
        Vector3 attackzone;
        int iwo = -1;
        Vehicle tempveh;
        bool nextfreeze = false;
        Vehicle veh1;
        Vehicle veh2;
        Vehicle veh3;
        bool created = false;
        int currentobjective;
        Ped newped;
        int iwody;
        bool finalavail = false;
        int iwodc;
        Vector3 lastzone;
        List<Ped> subenemlist = new List<Ped>();
        List<Ped> mainenemlist = new List<Ped>();
        List<Ped> secenemlist = new List<Ped>();
        float addztimes = 0;
        bool nextnocollision = false;
        bool defaultlod = false;
        bool nextpropsvisible = true;
        Prop rootprop;
        bool setattack = true;
        Ped cenem1;
        Ped cenem2;
        Ped cenem3;
        Ped cenem4;
        Ped cenem5;
        Ped cenem6;
        Ped cenem7;
        Ped cenem8;
        Ped cenem9;
        Ped cenem10;
        Ped cenem11;
        Ped cenem12;
        Ped cenem13;
        Ped cenem14;
        Ped cenem15;
        Ped cenem16;
        Ped cenem17;
        Ped cenem18;
        Ped cenem19;
        Ped cenem20;
        Ped cenem21;

        Ped menem1;
        Ped menem2;
        Ped menem3;
        Ped menem4;
        Ped menem5;
        Ped menem6;
        Ped menem7;
        Ped menem8;
        Ped menem9;
        Ped menem10;
        Ped menem11;
        Ped menem12;
        Ped menem13;
        Ped menem14;
        Ped menem15;
        Ped menem16;
        Ped menem17;
        Ped menem18;
        Ped menem19;
        Ped menem20;
        Ped menem21;
        Ped menem22;
        Ped menem23;
        Ped menem24;
        Ped menem25;
        Ped menem26;
        Ped senem1;
        Ped senem2;
        Ped senem3;
        Ped senem4;
        Ped senem5;
        Ped senem6;
        Ped senem7;
        Ped senem8;
        Ped senem9;
        Ped senem10;
        Ped senem11;
        Ped senem12;
        Ped senem13;
        Ped senem14;
        Ped senem15;
        Ped senem16;
        Ped senem18;
        Ped senem19;
        Ped senem20;
        Ped senem21;
        Ped senem22;
        Ped senem23;
        Ped senem24;
        Blip tblip2;
        Ped menem27;
        Blip ablip;
        string subbase = "False";
        string secondbase = "False";
        bool attackonce = true;
        Blip tblip3;
        Blip tblip4;
        Blip tblip5;
        Prop boxprop;
        Vector3 azonepos;
        Vector3 bzonepos;
        Vector3 czonepos;
        Vector3 atzonepos;
        int chests = -1;
        int warmenu = -1;
        Vector3 cpos1;
        Vector3 cpos2;
        Vector3 cpos3;
        Vector3 cpos4;
        Vector3 cpos5;
        Vector3 cpos6;
        float cr1;
        float cr2;
        float cr3;
        float cr4;
        float cr5;
        float cr6;

        List<Vector3> poslist = new List<Vector3>();
        int spawns = -1;
        int randint;
        bool unactive = false;
        int stage;
        Vector3 triggerpos;
        int objsw = -1;
        bool specialwaitover = true;
        int specialwaittime;
        Blip objblip;
        bool relationmade = false;
        Ped temped4;
        Ped temped3;
        Ped temped5;
        Ped enem20;
        Ped enem21;
        Blip missionblip;
        System.Media.SoundPlayer soundPlayer;
        System.Media.SoundPlayer soundPlayer2;
        bool objectiveblip = false;
        bool goodmade = false;
        List<Ped> enemlist = new List<Ped>();
        int bulletcount1 = 0;
        int bulletcount2 = 0;
        int bulletcount3 = 0;
        int bulletcount4 = 0;
        Blip objb1;
        Blip objb2;
        Blip objb3;
        Blip objb4;
        int timer1;
        int timer2;
        int timer3;
        int timer4;
        int brutes = -1;
        int brutec = -1;
        Ped bruteped;
        Vector3 spawnpos;
        bool disableplayermove = false;
        bool saidline = false;
        Vehicle pv;
        bool invince = false;
        Vector3 spawnpos2;
        Vector3 spawnpos3;
        Vehicle objveh;
        bool disablemusic = false;
        Prop shiproot;
        string mo;
        int ps1bv;
        int ps2bv;
        int ps3bv;
        string currentlocation;
        Vector3 ipos1;
        Vector3 ipos2;
        Vector3 ipos3;
        int cplant;
        int ts;
        string toplant;
        Vector3 f;
        Vector3 f2;
        float rt;
        bool canpr;
        bool p2m = false;
        Vector3 farea1;
        Vector3 farea2;
        Vector3 farea3;
        Vector3 farea4;
        int fstage1 = 0;
        int fstage2 = 0;
        int fstage3 = 0;
        int fstage4 = 0;
        bool pcount;
        int wcount;
        Vector3 wpos;
        bool wmode;
        Prop addmoneybox;
        Prop mb1;
        Prop mb2;
        Prop mb3;
        Prop mb4;
        bool didex;
        Vector3 qa;
        Vector3 ch1;
        Vector3 ch2;
        Vector3 ch3;
        int ccount;
        bool cd1;
        bool cd2;
        bool cd3;
        Vector3 h1;
        Vector3 h2;
        Vector3 h3;
        int hc;
        bool hd1;
        bool hd2;
        bool hd3;
        string wr;
        List<Blip> wlist = new List<Blip>();
        bool addtowl = false;
        Prop mb5;
        Entity rped;
        bool held = false;
        bool chex = false;
        string rmodel;
        int outfit;
        Prop mb6;
        Prop mb7;
        Prop mb8;
        Vector3 spo;
        public RDR2Ransom_V2()
        {

            KeyDown += onKeyDown;

  
            Tick += OnTick;
            Interval = 1;
        }
        private void OnTick(object sender, EventArgs evt)
        {
            if (disablemusic)
            {
                RDR2.Native.AUDIO.SET_AUDIO_FLAG("OpenWorldMusicDisabled", true);
            }
            else
            {
                RDR2.Native.AUDIO.SET_AUDIO_FLAG("OpenWorldMusicDisabled", false);
            }

            if (disableplayermove)
            {
                Game.DisableControlThisFrame(eInputType.Sprint);
                Game.DisableControlThisFrame(eInputType.Cover);
                Game.DisableControlThisFrame(eInputType.OpenWheelMenu);
                Game.DisableControlThisFrame(eInputType.MoveDownOnly);
                Game.DisableControlThisFrame(eInputType.MoveLeftOnly);
                Game.DisableControlThisFrame(eInputType.MoveLR);
                Game.DisableControlThisFrame(eInputType.MoveRightOnly);
                Game.DisableControlThisFrame(eInputType.MoveUD);
                Game.DisableControlThisFrame(eInputType.MoveUpOnly);
                Game.DisableControlThisFrame(eInputType.Attack);
                Game.DisableControlThisFrame(eInputType.ScriptRightAxisX);
                Game.DisableControlThisFrame(eInputType.ScriptRightAxisY);
                Game.DisableControlThisFrame(eInputType.ScriptLeftAxisX);
                Game.DisableControlThisFrame(eInputType.ScriptLeftAxisY);
                Game.DisableControlThisFrame(eInputType.FrontendAxisX);
                Game.DisableControlThisFrame(eInputType.FrontendAxisY);
                Game.DisableControlThisFrame(eInputType.FrontendAxisX);
            }
            switch (nolaw)
            {
                case 1:
                    {
                        RDR2.Native.LAW._SET_LAW_DISABLED(false);
                        RDR2.Native.LAW.SET_DISABLE_DISTURBANCE_CRIMES(Game.Player, false);
                        nolaw = -1;
                    }
                    break;
                case 0:
                    {
                        RDR2.Native.LAW._SET_LAW_DISABLED(true);
                        RDR2.Native.LAW.SET_DISABLE_DISTURBANCE_CRIMES(Game.Player, true);
                        RDR2.Native.PLAYER.CLEAR_PLAYER_WANTED_LEVEL(Game.Player);
                    }
                    break;
            }
            switch (ma)
            {
                case 0:
                    {
                        //if (MyIni.Read("Settings", "Ransom Active") == "True")
                        //   {
                        //       outfit = int.Parse(MyIni.Read("Settings", "Ransom Outfit"));
                        //   }
                        ma = 1;
                    }
                    break;

                case 1:
                    {
                        if (Game.Player.Character.IsCarryingSomething)
                        {
                            objectiveblip = true;
                            rped = PED._GET_FIRST_ENTITY_PED_IS_CARRYING(Game.Player.Character);
                            ma = 2;
                        }

                    }
                    break;
                case 2:
                    {
                        if (!Game.Player.Character.IsCarryingSomething)
                        {
                            ma = 1;
                        }
                        if (Game.IsControlJustPressed(eInputType.Enter))
                        {
                            if (ENTITY.IS_ENTITY_A_PED(rped))
                            {
                                if (PED.IS_PED_HUMAN(rped))
                                {
                                    if (rped.IsAlive)
                                    {
                                        ma = 3;
                                    }

                                }

                            }

                            //timer1 = Game.GameTime + 8000;
                            //held = true;
                        }
                        if (Game.IsControlReleased(eInputType.Jump))
                        {
                            held = false;
                        }
                        if (held && Game.GameTime > timer1)
                        {
                            //        substitle("Head to a post office to send a ransom letter.");
                            ma = 3;
                        }
                    }
                    break;
                case 3:
                    {


                        //spawnblip(new Vector3(-1097.948f, -573.3557f, 82.39515f), eBlipSprite.BLIP_POST_OFFICE,"Ransom",true);//rigs
                        //spawnblip(new Vector3(-1769.165f, -384.5189f, 157.7153f), eBlipSprite.BLIP_POST_OFFICE, "Ransom", true);//straw
                        //spawnblip(new Vector3(-1298.042f, 404.5308f, 95.38389f), eBlipSprite.BLIP_POST_OFFICE, "Ransom", true);//wallace
                        //spawnblip(new Vector3(-877.4915f, -1343.723f, 43.29034f), eBlipSprite.BLIP_POST_OFFICE, "Ransom", true);//black
                        //spawnblip(new Vector3(-5230.128f, -3466.269f, -20.57084f), eBlipSprite.BLIP_POST_OFFICE, "Ransom", true);//benedict
                        //spawnblip(new Vector3(-180.379f, 648.0441f, 113.5801f), eBlipSprite.BLIP_POST_OFFICE, "Ransom", true);//val
                        //spawnblip(new Vector3(1521.89f, 451.6016f, 90.36218f), eBlipSprite.BLIP_POST_OFFICE, "Ransom", true);//em
                        //spawnblip(new Vector3(1231.004f, -1277.44f, 76.02334f), eBlipSprite.BLIP_POST_OFFICE, "Ransom", true);//rhode
                        //spawnblip(new Vector3(2932.015f, 1301.232f, 44.47972f), eBlipSprite.BLIP_POST_OFFICE, "Ransom", true);//ann
                        //spawnblip(new Vector3(2754.197f, -1395.21f, 46.2108f), eBlipSprite.BLIP_POST_OFFICE, "Ransom", true);//sain
                        spawnblip(new Vector3(-1993.97f, -291.77f, 190.76f), eBlipSprite.BLIP_POST_OFFICE, "Ransom", true);//straw
                        spawnproptolist("s_lootablemoneybox", new Vector3(-1993.97f, -291.77f, 190.76f), new Vector3(0, 0, 46), true, true, proplist);
                        mb1 = temprop;
                        spawnblip(new Vector3(-905.57f, -1017.81f, 43.47f), eBlipSprite.BLIP_POST_OFFICE, "Ransom", true);//bl
                        spawnproptolist("s_lootablemoneybox", new Vector3(-905.57f, -1017.81f, 43.47f), new Vector3(0, 0, -70), true, true, proplist);
                        mb2 = temprop;
                        spawnblip(new Vector3(-313.39f, 1297.39f, 146.45f), eBlipSprite.BLIP_POST_OFFICE, "Ransom", true);//val
                        spawnproptolist("s_lootablemoneybox", new Vector3(-313.39f, 1297.39f, 146.45f), new Vector3(0, 0, -142), true, true, proplist);
                        mb3 = temprop;
                        spawnblip(new Vector3(1896.24f, 860.91f, 107.49f), eBlipSprite.BLIP_POST_OFFICE, "Ransom", true);//eme
                        spawnproptolist("s_lootablemoneybox", new Vector3(1896.24f, 860.91f, 107.49f), new Vector3(0, 0, -160), true, true, proplist);
                        mb4 = temprop;
                        spawnblip(new Vector3(1637.88f, -820.29f, 39.72f), eBlipSprite.BLIP_POST_OFFICE, "Ransom", true);//saint
                        spawnproptolist("s_lootablemoneybox", new Vector3(1637.88f, -820.29f, 39.72f), new Vector3(0, 0, 98), true, true, proplist);
                        mb5 = temprop;
                        spawnblip(new Vector3(763.83f, -853.87f, 54.29f), eBlipSprite.BLIP_POST_OFFICE, "Ransom", true);//rhodes
                        spawnproptolist("s_lootablemoneybox", new Vector3(763.83f, -853.87f, 54.29f), new Vector3(0, 0, 96), true, true, proplist);
                        mb6 = temprop;
                        spawnblip(new Vector3(2693.22f, 1655.69f, 147.23f), eBlipSprite.BLIP_POST_OFFICE, "Ransom", true);//annes
                        spawnproptolist("s_lootablemoneybox", new Vector3(2693.22f, 1655.69f, 147.23f), new Vector3(0, 0, 96), true, true, proplist);
                        mb7 = temprop;
                        spawnblip(new Vector3(-4367.94f, -3075.24f, -10.92f), eBlipSprite.BLIP_POST_OFFICE, "Ransom", true);//tumbl
                        spawnproptolist("s_lootablemoneybox", new Vector3(-4367.94f, -3075.24f, -10.92f), new Vector3(0, 0, 74), true, true, proplist);
                        mb8 = temprop;

                        createrelations();
                        chex = false;
                        ma = 4;
                    }
                    break;
                case 4:
                    {
                        substitle("Head to one of the discreet locations to exchange your hostage for money.");

                        if (rped.Position.DistanceTo(Game.Player.Character.Position) < 3)
                        {
                            if (Game.Player.Character.Position.DistanceTo(new Vector3(-1993.97f, -291.77f, 190.76f)) < 9)
                            {
                                spo = new Vector3(-2017.018f, -310.8653f, 187.3498f);
                                spawnproptolist("s_inv_moneyclip01x", mb7.Position, mb7.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb6.Position, mb6.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb5.Position, mb5.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb4.Position, mb4.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb3.Position, mb3.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb2.Position, mb2.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb1.Position, mb1.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb8.Position, mb8.Rotation, true, true, proplist);
                                ma = 411;
                            }
                            if (Game.Player.Character.Position.DistanceTo(new Vector3(-905.57f, -1017.81f, 43.47f)) < 9)
                            {
                                spo = new Vector3(-921.994f, -992.6297f, 45.46917f);
                                spawnproptolist("s_inv_moneyclip01x", mb7.Position, mb7.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb6.Position, mb6.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb5.Position, mb5.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb4.Position, mb4.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb3.Position, mb3.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb2.Position, mb2.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb1.Position, mb1.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb8.Position, mb8.Rotation, true, true, proplist);
                                ma = 411;
                            }
                            if (Game.Player.Character.Position.DistanceTo(new Vector3(-313.39f, 1297.39f, 146.45f)) < 9)
                            {
                                spo = new Vector3(-339.7252f, 1286.951f, 145.7653f);
                                spawnproptolist("s_inv_moneyclip01x", mb7.Position, mb7.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb6.Position, mb6.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb5.Position, mb5.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb4.Position, mb4.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb3.Position, mb3.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb2.Position, mb2.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb1.Position, mb1.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb8.Position, mb8.Rotation, true, true, proplist);
                                ma = 411;
                            }
                            if (Game.Player.Character.Position.DistanceTo(new Vector3(1896.24f, 860.91f, 107.49f)) < 9)
                            {
                                spo = new Vector3(1928.856f, 893.3802f, 114.876f);
                                spawnproptolist("s_inv_moneyclip01x", mb7.Position, mb7.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb6.Position, mb6.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb5.Position, mb5.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb4.Position, mb4.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb3.Position, mb3.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb2.Position, mb2.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb1.Position, mb1.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb8.Position, mb8.Rotation, true, true, proplist);
                                ma = 411;
                            }
                            if (Game.Player.Character.Position.DistanceTo(new Vector3(1637.88f, -820.29f, 39.72f)) < 9)
                            {
                                spo = new Vector3(1637.435f, -857.8792f, 41.01533f);
                                spawnproptolist("s_inv_moneyclip01x", mb7.Position, mb7.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb6.Position, mb6.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb5.Position, mb5.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb4.Position, mb4.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb3.Position, mb3.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb2.Position, mb2.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb1.Position, mb1.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb8.Position, mb8.Rotation, true, true, proplist);
                                ma = 411;
                            }
                            if (Game.Player.Character.Position.DistanceTo(new Vector3(763.83f, -853.87f, 54.29f)) < 9)
                            {
                                spo = new Vector3(750.4595f, -857.2563f, 54.60955f);
                                spawnproptolist("s_inv_moneyclip01x", mb7.Position, mb7.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb6.Position, mb6.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb5.Position, mb5.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb4.Position, mb4.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb3.Position, mb3.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb2.Position, mb2.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb1.Position, mb1.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb8.Position, mb8.Rotation, true, true, proplist);
                                ma = 411;
                            }
                            if (Game.Player.Character.Position.DistanceTo(new Vector3(2693.22f, 1655.69f, 147.23f)) < 9)
                            {
                                spo = new Vector3(2753.191f, 1664.006f, 154.8774f);
                                spawnproptolist("s_inv_moneyclip01x", mb7.Position, mb7.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb6.Position, mb6.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb5.Position, mb5.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb4.Position, mb4.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb3.Position, mb3.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb2.Position, mb2.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb1.Position, mb1.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb8.Position, mb8.Rotation, true, true, proplist);
                                ma = 411;
                            }
                            if (Game.Player.Character.Position.DistanceTo(new Vector3(-4367.94f, -3075.24f, -10.92f)) < 9)
                            {
                                spo = new Vector3(-4356.409f, -3124.689f, 0.007521287f);
                                spawnproptolist("s_inv_moneyclip01x", mb7.Position, mb7.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb6.Position, mb6.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb5.Position, mb5.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb4.Position, mb4.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb3.Position, mb3.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb2.Position, mb2.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb1.Position, mb1.Rotation, true, true, proplist);
                                spawnproptolist("s_inv_moneyclip01x", mb8.Position, mb8.Rotation, true, true, proplist);
                                ma = 411;
                            }
                        }

                    }
                    break;
                case 411:
                    {
                        substitle("Untie your hostage.");
                        if (!PED.IS_PED_HOGTIED(rped))
                        {
                            TASK.TASK_FLEE_PED(rped, Game.Player.Character, 2, 0, -1f, -1, 0);
                            ma = 41;
                        }
                    }
                    break;
                case 41:
                    {
                        substitle("Collect your money.");
                        foreach (Prop prop in proplist)
                        {
                            if (ENTITY.DOES_ENTITY_EXIST(prop))
                            {
                                if (!prop.IsVisible)
                                {
                                    chex = true;
                                }
                            }
                        }
                        if (chex)
                        {
                            h1 = Game.Player.Character.Position;
                            ma = 5;

                            Vector3 da;
                            da = spo;
                            enem1 = spawnped("s_m_m_dispatchlawrural_01", da, 0, true);
                            enem2 = spawnped("s_m_m_dispatchlawrural_01", da, 0, true);
                            enem3 = spawnped("s_m_m_dispatchlawrural_01", da, 0, true);
                            enem4 = spawnped("s_m_m_dispatchlawrural_01", da, 0, true);
                            enem5 = spawnped("s_m_m_dispatchlawrural_01", da, 0, true);
                            enem6 = spawnped("s_m_m_dispatchlawrural_01", da, 0, true);
                            enem7 = spawnped("s_m_m_dispatchlawrural_01", da, 0, true);
                            ma = 5;
                        }
                    }
                    break;
                case 5:
                    {
                        substitle("Leave the area.");
                        if (Game.Player.Character.Position.DistanceTo(h1) > 100)
                        {
                            foreach (Prop prop in proplist)
                            {
                                if (ENTITY.DOES_ENTITY_EXIST(prop))
                                {
                                    prop.Delete();
                                }
                            }
                            foreach (Blip blip in bliplist)
                            {
                                if (MAP.DOES_BLIP_EXIST(blip))
                                {
                                    blip.Delete();
                                }
                            }
                            foreach (Ped ped in pedlist)
                            {
                                if (ENTITY.DOES_ENTITY_EXIST(ped))
                                {
                                    ped.Delete();
                                }
                            }
                            pedlist.Clear();
                            bliplist.Clear();
                            proplist.Clear();
                            ma = 6;
                        }
                    }
                    break;
                case 6:
                    {
                        substitle("Ransom ended.");
                        Script.Wait(3000);
                        ma = 1;
                    }
                    break;
               

            }





            //MainPart


        }



        void spawnproptolist(string modelname, Vector3 pos, Vector3 rot, bool freeze, bool collision, List<Prop> list)
        {
            //adddebugcount += 1;
            // Script.Wait(200);
            Model models = new Model(modelname);
            models.Request(10000);
            if (models.IsValid && models.IsInCdImage)
            {
                while (!models.IsLoaded) Script.Wait(50);
                temprop = World.CreateProp(models, pos, rot, false, false);
                if (modelname == "mp_big_rock_scan_07")
                {
                    temprop.Position = new Vector3(pos.X, pos.Y, pos.Z - .5f);
                }
                temprop.HasCollision = collision;
                if (nextnocollision)
                {
                    temprop.HasCollision = false;
                }
                ENTITY.FREEZE_ENTITY_POSITION(temprop, freeze);
                if (!defaultlod)
                {
                    temprop.LodDistance = 900;
                }
                if (!nextpropsvisible)
                {
                    temprop.IsVisible = false;
                }
                list.Add(temprop);
                lastpropindex = list.IndexOf(temprop);


            }
        }

        void spawnblip(Vector3 c, eBlipSprite blipt, string name, bool addtolist)
        {

            if (blipt == eBlipSprite.Stranger)
            {
                objectiveblip = false;
            }
            if (objectiveblip)
            {
                loot1blip = World.CreateBlip(c, BlipType.BLIP_STYLE_NEUTRAL_OBJECTIVE);
                loot1blip.AddModifier(eBlipModifier.BLIP_MODIFIER_OBJECTIVE);
            }
            else
            {
                loot1blip = World.CreateBlip(c, BlipType.BLIP_STYLE_SHOP);
            }

            if (loot1blip.Exists()) ;

            if (blipt == eBlipSprite.Stranger)
            {
                loot1blip.AddModifier(eBlipModifier.BLIP_MODIFIER_MP_COLOR_20);
            }
            // Waypoint
            // rhodesblip.Sprite = BlipSprite.Bank;
            loot1blip.Label = name;
            loot1blip.Sprite = blipt;
            if (addtolist)
            {
                bliplist.Add(loot1blip);
                lastblipindex = bliplist.IndexOf(loot1blip);
            }
            if (addtowl)
            {
                wlist.Add(loot1blip);
            }
            //    loot1blip.AddModifier()
            //     loot1blip.AddModifier(eBlipModifier.);

        }
        private void onKeyDown(object sender, KeyEventArgs e)
        {

        }


        void substitle(string text)
        {
            if (!debugdisablesubs)
            {
                UI.PrintSubtitle(text);
            }
        }

        RDR2.UI.TextElement SetString(PointF xy, string text, float size, Color color)
        {
            RDR2.UI.TextElement main;
            main = new TextElement(text, xy, size, color, Alignment.Left, true, true);

            main.Enabled = true;
            return main;
        }

     
        void createrelations()
        {
            if (!created)
            {
                World.AddRelationshipGroup("gooder");
                World.SetRelationshipBetweenGroups(eRelationshipType.Like, RDR2.Native.MISC.GET_HASH_KEY("gooder"), Game.Player.Character.RelationshipGroup);
                World.AddRelationshipGroup("badder");
                World.SetRelationshipBetweenGroups(eRelationshipType.Hate, RDR2.Native.MISC.GET_HASH_KEY("badder"), Game.Player.Character.RelationshipGroup);
                World.SetRelationshipBetweenGroups(eRelationshipType.Hate, RDR2.Native.MISC.GET_HASH_KEY("badder"), RDR2.Native.MISC.GET_HASH_KEY("gooder"));
                World.SetRelationshipBetweenGroups(eRelationshipType.Hate, RDR2.Native.MISC.GET_HASH_KEY("gooder"), RDR2.Native.MISC.GET_HASH_KEY("badder"));
                created = true;
            }
        }


      
        Ped spawnped(string model, Vector3 pos, float heading, bool isbad)
        {
            Model models = new Model(model);
            models.Request(10000);
            if (models.IsValid && models.IsInCdImage)
            {
                while (!models.IsLoaded) Script.Wait(50);
                newped = World.CreatePed(models, new Vector3(pos.X, pos.Y, pos.Z + 1), heading);
                newped.RandomizeOutfit();
                if (isbad)
                {
                    if (ENTITY.DOES_ENTITY_EXIST(newped))
                    {
                        newped.Speed = .6f;
                        newped.RelationshipGroup = RDR2.Native.MISC.GET_HASH_KEY("badder");
                        newped.SetConfigFlag(ePedScriptConfigFlags.PCF_DisableHonorModifiers, true);
                        // Script.Wait(300);
                        if (setattack)
                        {
                            newped.Task.FightAgainstHatedTargets(99999);

                        }


                        newped.Weapons.Give(0x772C8DD6, 900);
                        newped.Weapons.Select(0x772C8DD6);
                        newped.Weapons.Current.InfiniteAmmo = true;
                        PED._SET_PED_DESIRED_LOCO_FOR_MODEL(newped, "casual");
                        PED._SET_PED_DESIRED_LOCO_MOTION_TYPE(newped, "default_brave");
                    }


                }
                else
                {
                    if (ENTITY.DOES_ENTITY_EXIST(newped))
                    {
                        newped.Speed = .6f;
                        newped.RelationshipGroup = RDR2.Native.MISC.GET_HASH_KEY("gooder");
                        newped.SetConfigFlag(ePedScriptConfigFlags.PCF_DisableHonorModifiers, true);
                        //   Script.Wait(300);
                        if (setattack)
                        {
                            newped.Task.FightAgainstHatedTargets(99999);

                        }
                        newped.Weapons.Give(0x772C8DD6, 900);
                        newped.Weapons.Select(0x772C8DD6);
                        newped.SetConfigFlag(ePedScriptConfigFlags.PCF_CanAttackFriendly, false);
                        //         PED.can
                        newped.Weapons.Current.InfiniteAmmo = true;
                        newped.SetConfigFlag(ePedScriptConfigFlags.PCF_DisableAndBreakAimLockOntoThisPed, true);
                        PED._SET_PED_DESIRED_LOCO_FOR_MODEL(newped, "casual");
                        PED._SET_PED_DESIRED_LOCO_MOTION_TYPE(newped, "default_brave");
                    }

                }
                if (ENTITY.DOES_ENTITY_EXIST(newped))
                {
                    if (nextfreeze)
                    {
                        ENTITY.FREEZE_ENTITY_POSITION(newped, true);
                    }
                    newped.LodDistance = 500;
                    return newped;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
        void preventflee(Ped ped)
        {
            RDR2.Native.PED.SET_PED_FLEE_ATTRIBUTES(ped, 0, false);
            RDR2.Native.PED.SET_BLOCKING_OF_NON_TEMPORARY_EVENTS(ped, true);
        }
      
    }
}
