﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using L2Script.Packets.Game;
using L2Script.Library;

namespace L2Script.Plugins.R4Toolkit.InformationExtension.Packets
{
    public static class UserInfo
    {
        public static Character parsePacket(GameReader packet)
        {
            Character toon = new Character();
            toon.X = packet.readD();
            toon.Y = packet.readD();
            toon.Z = packet.readD();
            toon.isInAirShip = packet.readD();
            toon.ObjectID = packet.readD();
            toon.Name = packet.readS();
            toon.Race = packet.readD();
            toon.Sex = packet.readD();
            toon.ClassID = packet.readD();
            toon.Level = packet.readD();
            toon.Exp = packet.readQ();
            toon.Str = packet.readD();
            toon.Dex = packet.readD();
            toon.Con = packet.readD();
            toon.Int = packet.readD();
            toon.Wit = packet.readD();
            toon.Men = packet.readD();
            toon.MaxHP = packet.readD();
            toon.CurrentHP = packet.readD();
            toon.MaxMP = packet.readD();
            toon.CurrentMP = packet.readD();
            toon.Sp = packet.readD();
            toon.CurrentLoad = packet.readD();
            toon.MaxLoad = packet.readD();
            toon.WeaponEquipment = packet.readD();
            toon.Under = packet.readD();
            toon.Rear = packet.readD();
            toon.Lear = packet.readD();
            toon.Neck = packet.readD();
            toon.Finger = packet.readD();
            toon.Lfinger = packet.readD();
            toon.Head = packet.readD();
            toon.Rhand = packet.readD();
            toon.Lhand = packet.readD();
            toon.Gloves = packet.readD();
            toon.Chest = packet.readD();
            toon.Legs = packet.readD();
            toon.Feet = packet.readD();
            toon.Back = packet.readD();
            toon.Lrhand = packet.readD();
            toon.Hair = packet.readD();
            toon.Hair2 = packet.readD();
            toon.Rbracelet = packet.readD();
            toon.Lbracelet = packet.readD();
            toon.Deco = packet.readD();
            toon.Deco2 = packet.readD();
            toon.Deco3 = packet.readD();
            toon.Deco4 = packet.readD();
            toon.Deco5 = packet.readD();
            toon.Deco6 = packet.readD();
            toon.Belt = packet.readD();
            toon.IDUnder = packet.readD();
            toon.IDRear = packet.readD();
            toon.IDLear = packet.readD();
            toon.IDNeck = packet.readD();
            toon.IDFinger = packet.readD();
            toon.IDLfinger = packet.readD();
            toon.IDHead = packet.readD();
            toon.IDRhand = packet.readD();
            toon.IDLhand = packet.readD();
            toon.IDGloves = packet.readD();
            toon.IDChest = packet.readD();
            toon.IDLegs = packet.readD();
            toon.IDFeet = packet.readD();
            toon.IDBack = packet.readD();
            toon.IDLrhand = packet.readD();
            toon.IDHair = packet.readD();
            toon.IDHair2 = packet.readD();
            toon.IDRbracelet = packet.readD();
            toon.IDLbracelet = packet.readD();
            toon.IDDeco = packet.readD();
            toon.IDDeco2 = packet.readD();
            toon.IDDeco3 = packet.readD();
            toon.IDDeco4 = packet.readD();
            toon.IDDeco5 = packet.readD();
            toon.IDDeco6 = packet.readD();
            toon.IDBelt = packet.readD();
            toon.AugIDUnder = packet.readD();
            toon.AugIDRear = packet.readD();
            toon.AugIDLear = packet.readD();
            toon.AugIDNeck = packet.readD();
            toon.AugIDFinger = packet.readD();
            toon.AugIDLfinger = packet.readD();
            toon.AugIDHead = packet.readD();
            toon.AugIDRhand = packet.readD();
            toon.AugIDLhand = packet.readD();
            toon.AugIDGloves = packet.readD();
            toon.AugIDChest = packet.readD();
            toon.AugIDLegs = packet.readD();
            toon.AugIDFeet = packet.readD();
            toon.AugIDBack = packet.readD();
            toon.AugIDLrhand = packet.readD();
            toon.AugIDHair = packet.readD();
            toon.AugIDHair2 = packet.readD();
            toon.AugIDRbracelet = packet.readD();
            toon.AugIDLbracelet = packet.readD();
            toon.AugIDDeco = packet.readD();
            toon.AugIDDeco2 = packet.readD();
            toon.AugIDDeco3 = packet.readD();
            toon.AugIDDeco4 = packet.readD();
            toon.AugIDDeco5 = packet.readD();
            toon.AugIDDeco6 = packet.readD();
            toon.AugIDBelt = packet.readD();
            toon.TalismanSlots = packet.readD();
            packet.readD();
            toon.Patk = packet.readD();
            toon.PatkSpd = packet.readD();
            toon.Pdef = packet.readD();
            toon.EvasionRate = packet.readD();
            toon.Accuracy = packet.readD();
            toon.CriticalHit = packet.readD();
            toon.Matk = packet.readD();
            toon.MatkSpd = packet.readD();
            toon.PatkSpd = packet.readD();
            toon.Mdef = packet.readD();
            toon.PvPFlag = packet.readD();
            toon.Karma = packet.readD();
            toon.RunSpd = packet.readD();
            toon.WalkSpd = packet.readD();
            toon.SwimRunSpd = packet.readD();
            toon.SwimWalkSpd = packet.readD();
            packet.readD();
            packet.readD();
            toon.FlyRunSpd = packet.readD();
            toon.FlyWalkSpd = packet.readD();
            toon.MoveMul = packet.readF();
            toon.AtkSpeedMul = packet.readF();
            toon.ColRadius = packet.readF();
            toon.ColHeight = packet.readF();
            toon.HairStyle = packet.readD();
            toon.HairColor = packet.readD();
            toon.Face = packet.readD();
            toon.isGM = packet.readD();
            toon.Title = packet.readS();
            toon.ClanID = packet.readD();
            toon.ClanCrestID = packet.readD();
            toon.AllyID = packet.readD();
            toon.AllyCrestID = packet.readD();
            toon.Relation = packet.readD();
            toon.MountType = packet.readC();
            toon.PrivateStoreType = packet.readC();
            toon.DwarvenCraft = packet.readC();
            toon.PkKills = packet.readD();
            toon.PvPKills = packet.readD();
            toon.CubicsSize = packet.readH();
            toon.CubicID = packet.readH();
            packet.readC();
            toon.AbnormalEffect = packet.readD();
            toon.FlayingMounted = packet.readC();
            toon.ClanPrivileges = packet.readD();
            toon.RecomLeft = packet.readH();
            toon.RecomHave = packet.readH();
            toon.MountNpcID = packet.readD();
            toon.InventoryLimit = packet.readH();
            toon.ClassID = packet.readD();
            packet.readD();
            toon.MaxCP = packet.readD();
            toon.CurrentCP = packet.readD();
            toon.isMounted = packet.readC();
            toon.Team = packet.readC();
            toon.ClanCrestLargeID = packet.readD();
            toon.isNoble = packet.readC();
            toon.isHero = packet.readC();
            toon.isFishing = packet.readC();
            toon.FishingX = packet.readD();
            toon.FishingY = packet.readD();
            toon.FishingZ = packet.readD();
            toon.NameColor = packet.readD();
            toon.isRunning = packet.readC();
            toon.PledgeClass = packet.readD();
            toon.PledgeType = packet.readD();
            toon.TitleColor = packet.readD();
            toon.CursedWeaponEquipID = packet.readD();
            toon.TranformationID = packet.readD();
            toon.AtkElementAttr = packet.readH();
            toon.AttackElementVal = packet.readH();
            toon.DefAttrFire = packet.readH();
            toon.DefAttrWater = packet.readH();
            toon.DefAttrWind = packet.readH();
            toon.DefAttrEarth = packet.readH();
            toon.DefAttrHoly = packet.readH();
            toon.DefAttrDark = packet.readH();
            toon.AgathionId = packet.readD();
            toon.Fame = packet.readD();
            packet.readD();
            toon.VitalityPoints = packet.readD();
            packet.readD();
            packet.readD();
            packet.readD();
            return toon;
        }
    }
}