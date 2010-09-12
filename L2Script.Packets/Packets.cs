﻿namespace L2Script.Packets
{
    public class PacketList
    {
        public static string EnterWorld = "11 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 C9 BC F2 A7 66 5A 0B 98 36 A5 BD 89 ED 7F E4 D7 6B 49 E2 9F EF 76 EB CE A3 FA F4 BF 0C 64 A3 B4 A4 CE DC C6 08 3E 6E EA 45 CA D3 FE 88 13 87 B8 06 2C 96 F0 9B 1E 8E BC C6 9B 98 C8 63 16 CF D0 BE 18 00 00 C0 A8 01 43 C0 A8 01 FE D9 29 BF 7A D9 2F 29 A1 D9 2F 29 45";
        public enum Server : int
        {
            Die = 0x00,
            Revive = 0x01,
            AttackOutofRange = 0x02,
            AttackinCoolTime = 0x03,
            AttackDeadTarget = 0x04,
            SpawnItem = 0x05,
            SellList = 0x06,
            BuyList = 0x07,
            DeleteObject = 0x08,
            CharacterSelectionInfo = 0x09,
            LoginFail = 0x0A,
            CharacterSelectedPacket = 0x0B,
            NpcInfo = 0x0C,
            NewCharacterSuccess = 0x0D,
            NewCharacterFail = 0x0E,
            CharCreateOk = 0x0F,
            CharCreateFail = 0x10,
            ItemList = 0x11,
            SunRise = 0x12,
            SunSet = 0x13,
            TradeStartPacket = 0x14,
            TradeStartOkPacket = 0x15,
            DropItem = 0x16,
            GetItem = 0x17,
            StatusUpdate = 0x18,
            NpcHtmlMessage = 0x19,
            TradeOwnAddPacket = 0x1A,
            TradeOtherAddPacket = 0x1B,
            TradeDonePacket = 0x1C,
            CharacterDeleteSuccess = 0x1D,
            CharacterDeleteFail = 0x1E,
            ActionFail = 0x1F,
            ServerClose = 0x20,
            InventoryUpdatePacket = 0x21,
            TeleportToLocationPacket = 0x22,
            TargetSelectedPacket = 0x23,
            TargetUnselectedPacket = 0x24,
            AutoAttackStartPacket = 0x25,
            AutoAttackStopPacket = 0x26,
            SocialActionPacket = 0x27,
            ChangeMoveTypePacket = 0x28,
            ChangeWaitTypePacket = 0x29,
            ManagePledgePowerPacket = 0x2A,
            CreatePledgePacket = 0x2B,
            AskJoinPledgePacket = 0x2C,
            JoinPledgePacket = 0x2D,
            VersionCheck = 0x2E,
            MoveToLocation = 0x2F,
            NcpSay = 0x30,
            CharInfo = 0x31,
            UserInfo = 0x32,
            Attack = 0x33,
            WithdrawalPledgePacket = 0x34,
            OustPledgeMemberPacket = 0x35,
            SetOustPledgeMemberPacket = 0x36,
            DismissPledgePacket = 0x37,
            SetDismissPledgePacket = 0x38,
            AskJoinPartyPacket = 0x39,
            JoinPartyPacket = 0x3A,
            WithdrawalPartyPacket = 0x3B,
            OustPartyMemberPacket = 0x3C,
            SetOustPartyMemberPacket = 0x3D,
            DismissPartyPacket = 0x3E,
            SetDismissPartyPacket = 0x3F,
            MagicAndSkillList = 0x40,
            WareHouseDepositListPacket = 0x41,
            WareHouseWithdrawListPacket = 0x42,
            WareHouseDonePacket = 0x43,
            ShortCutRegisterPacket = 0x44,
            ShortCutInitPacket = 0x45,
            ShortCutDeletePacket = 0x46,
            StopMove = 0x47,
            MagicSkillUse = 0x48,
            MagicSkillCanceled = 0x49,
            CreatureSay = 0x4A,
            EquipUpdatePacket = 0x4B,
            DoorInfo = 0x4C,
            DoorStatusUpdate = 0x4D,
            PartySmallWindowAll = 0x4E,
            PartySmallWindowAddPacket = 0x4F,
            PartySmallWindowDeleteAllPacket = 0x50,
            PartySmallWindowDeletePacket = 0x51,
            PartySmallWindowUpdatePacket = 0x52,
            TradePressOwnOkPacket = 0x53,
            MagicSkillLaunchedPacket = 0x54,
            FriendAddRequestResult = 0x55,
            FriendAdd = 0x56,
            FriendRemove = 0x57,
            FriendList = 0x58,
            FriendStatus = 0x59,
            PledgeShowMemberListAllPacket = 0x5A,
            PledgeShowMemberListUpdatePacket = 0x5B,
            PledgeShowMemberListAddPacket = 0x5C,
            PledgeShowMemberListDeletePacket = 0x5D,
            MagicListPacket = 0x5E,
            SkillListPacket = 0x5F,
            OnVehicleInfo = 0x60,
            FinishRotating = 0x61,
            SystemMessagePacket = 0x62,
            StartPledgeWarPacket = 0x63,
            ReplyStartPledgeWarPacket = 0x64,
            StopPledgeWarPacket = 0x65,
            ReplyStopPledgeWarPacket = 0x66,
            SurrenderPledgeWarPacket = 0x67,
            ReplySurrenderPledgeWarPacket = 0x68,
            SetPledgeCrestPacket = 0x69,
            PledgeCrest = 0x6A,
            SetupGaugePacket = 0x6B,
            OnVehicleDeparture = 0x6C,
            OnVehicleCheckLocation = 0x6D,
            OnGetOnVehicle = 0x6E,
            OnGetOffVehicle = 0x6F,
            TradeRequestPacket = 0x70,
            RestartResponsePacket = 0x71,
            MoveToPawn = 0x72,
            SSQInfoPacket = 0x73,
            GameGuardQueryPacket = 0x74,
            L2FriendListPacket = 0x75,
            L2FriendPacket = 0x76,
            L2FriendStatusPacket = 0x77,
            L2FriendSayPacket = 0x78,
            ValidateLocation = 0x79,
            StartRotating = 0x7A,
            ShowBoardPacket = 0x7B,
            ChooseInventoryItemPacket = 0x7C,
            Dummy = 0x7D,
            MoveToLocationInVehicle = 0x7E,
            StopMoveInVehicle = 0x7F,
            ValidateLocationInVehicle = 0x80,
            TradeUpdatePacket = 0x81,
            TradePressOtherOkPacket = 0x82,
            //FriendAddRequestResult = 0x83,
            LeaveWorld = 0x84,
            AbnormalStatusUpdatePacket = 0x85,
            QuestListPacket = 0x86,
            EnchantResultPacket = 0x87,
            PledgeShowMemberListDeleteAllPacket = 0x88,
            PledgeInfo = 0x89,
            PledgeExtendedInfoPacket = 0x8A,
            SurrenderPersonallyPacket = 0x8B,
            Ride = 0x8C,
            //Dummy = 0x8D,
            PledgeShowInfoUpdatePacket = 0x8E,
            //ActionFail = 0x8F,
            AcquireSkillListPacket = 0x90,
            AcquireSkillInfoPacket = 0x91,
            ServerObjectInfoPacket = 0x92,
            GMHidePacket = 0x93,
            AcquireSkillDonePacket = 0x94,
            GMViewCharacterInfoPacket = 0x95,
            GMViewPledgeInfoPacket = 0x96,
            GMViewSkillInfoPacket = 0x97,
            GMViewMagicInfoPacket = 0x98,
            GMViewQuestInfoPacket = 0x99,
            GMViewItemListPacket = 0x9A,
            GMViewWarehouseWithdrawListPacket = 0x9B,
            ListPartyWatingPacket = 0x9C,
            PartyRoomInfoPacket = 0x9D,
            PlaySoundPacket = 0x9E,
            StaticObjectPacket = 0x9F,
            PrivateSellList = 0xA0,
            PrivateBuyList = 0xA1,
            PrivateStoreMsg = 0xA2,
            ShowMinimapPacket = 0xA3,
            ReviveRequestPacket = 0xA4,
            AbnormalVisualEffectPacket = 0xA5,
            TutorialShowHtml = 0xA6,
            TutorialShowQuestionMarkPacket = 0xA7,
            TutorialEnableClientEventPacket = 0xA8,
            TutorialCloseHtmlPacket = 0xA9,
            ShowRadarPacket = 0xAA,
            WithdrawAlliancePacket = 0xAB,
            OustAllianceMemberPledgePacket = 0xAC,
            DismissAlliancePacket = 0xAD,
            SetAllianceCrestPacket = 0xAE,
            AllianceCrest = 0xAF,
            ServerCloseSocketPacket = 0xB0,
            PetStatusShow = 0xB1,
            PetInfo = 0xB2,
            PetItemList = 0xB3,
            PetInventoryUpdatePacket = 0xB4,
            AllianceInfoPacket = 0xB5,
            PetStatusUpdatePacket = 0xB6,
            PetDeletePacket = 0xB7,
            DeleteRadarPacket = 0xB8,
            MyTargetSelectedPacket = 0xB9,
            PartyMemberPosition = 0xBA,
            AskJoinAlliancePacket = 0xBB,
            JoinAlliancePacket = 0xBC,
            //PrivateSellList = 0xBD,
            //PrivateBuyList = 0xBE,
            PrivateStoreBuyMsg = 0xBF,
            VehicleStartPacket = 0xC0,
            RequestTimeCheckPacket = 0xC1,
            StartAllianceWarPacket = 0xC2,
            ReplyStartAllianceWarPacket = 0xC3,
            StopAllianceWarPacket = 0xC4,
            ReplyStopAllianceWarPacket = 0xC5,
            SurrenderAllianceWarPacket = 0xC6,
            SkillCoolTimePacket = 0xC7,
            PackageToListPacket = 0xC8,
            CastleSiegeInfoPacket = 0xC9,
            CastleSiegeAttackerList = 0xCA,
            CastleSiegeDefenderList = 0xCB,
            NickNameChanged = 0xCC,
            PledgeStatusChanged = 0xCD,
            RelationChanged = 0xCE,
            OnEventTrigger = 0xCF,
            MultiSellListPacket = 0xD0,
            SetSummonRemainTimePacket = 0xD1,
            PackageSendableListPacket = 0xD2,
            EarthQuake = 0xD3,
            FlyToLocation = 0xD4,
            BlockListPacket = 0xD5,
            SpecialCamera = 0xD6,
            NormalCamera = 0xD7,
            OnSkillRemainSec = 0xD8,
            NetPingPacket = 0xD9,
            DicePacket = 0xDA,
            SnoopPacket = 0xDB,
            RecipeBookItemListPacket = 0xDC,
            RecipeItemMakeInfoPacket = 0xDD,
            RecipeShopManageListPacket = 0xDE,
            RecipeShopSellListPacket = 0xDF,
            RecipeShopItemInfoPacket = 0xE0,
            RecipeShopMsgPacket = 0xE1,
            ShowCalcPacket = 0xE2,
            RaceMonsterStatusUpdatePacket = 0xE3,
            HennaItemInfo = 0xE4,
            HennaInfoPacket = 0xE5,
            HennaUnequipListPacket = 0xE6,
            HennaUnequipItemInfo = 0xE7,
            MacroListPacket = 0xE8,
            BuyListSeed = 0xE9,
            ShowTownMapPacket = 0xEA,
            ObserverStartPacket = 0xEB,
            ObserverEndPacket = 0xEC,
            ChairSitPacket = 0xED,
            HennaEquipListPacket = 0xEE,
            SellListProcure = 0xEF,
            GMHennaInfoPacket = 0xF0,
            //ShowRadarPacket = 0xF1,
            ClientSetTimePacket = 0xF2,
            ConfirmDlgPacket = 0xF3,
            PartySpelled = 0xF4,
            PreviewList = 0xF5,
            ShopPreviewInfoPacket = 0xF6,
            CameraModePacket = 0xF7,
            ShowXMasSealPacket = 0xF8,
            EtcStatusUpdatePacket = 0xF9,
            ShortBuffStatusUpdatePacket = 0xFA,
            SSQStatusPacket = 0xFB,
            PetitionVotePacket = 0xFC,
            AgitDecoInfoPacket = 0xFD,
            DummyPacket = 0xFE,
            ExDummyPacket = 0xFE00,
            ExRegenMaxPacket = 0xFE01,
            ExEventMatchUserInfoPacket = 0xFE02,
            ExColosseumFenceInfoPacket = 0xFE03,
            ExEventMatchSpelledInfoPacket = 0xFE04,
            ExEventMatchFirecrackerPacket = 0xFE05,
            ExEventMatchTeamUnlockedPacket = 0xFE06,
            ExEventMatchGMTestPacket = 0xFE07,
            ExPartyRoomMemberPacket = 0xFE08,
            ExClosePartyRoomPacket = 0xFE09,
            ExManagePartyRoomMemberPacket = 0xFE0A,
            ExEventMatchLockResult = 0xFE0B,
            ExAutoSoulShot = 0xFE0C,
            ExEventMatchListPacket = 0xFE0D,
            ExEventMatchObserverPacket = 0xFE0E,
            ExEventMatchMessagePacket = 0xFE0F,
            ExEventMatchScorePacket = 0xFE10,
            ExServerPrimitivePacket = 0xFE11,
            ExOpenMPCCPacket = 0xFE12,
            ExCloseMPCCPacket = 0xFE13,
            ExShowCastleInfo = 0xFE14,
            ExShowFortressInfo = 0xFE15,
            ExShowAgitInfo = 0xFE16,
            ExShowFortressSiegeInfo = 0xFE17,
            ExPartyPetWindowAdd = 0xFE18,
            ExPartyPetWindowUpdate = 0xFE19,
            ExAskJoinMPCCPacket = 0xFE1A,
            ExPledgeEmblem = 0xFE1B,
            ExEventMatchTeamInfoPacket = 0xFE1C,
            ExEventMatchCreatePacket = 0xFE1D,
            ExFishingStartPacket = 0xFE1E,
            ExFishingEndPacket = 0xFE1F,
            ExShowQuestInfoPacket = 0xFE20,
            ExShowQuestMarkPacket = 0xFE21,
            ExSendManorListPacket = 0xFE22,
            ExShowSeedInfoPacket = 0xFE23,
            ExShowCropInfoPacket = 0xFE24,
            ExShowManorDefaultInfoPacket = 0xFE25,
            ExShowSeedSettingPacket = 0xFE26,
            ExFishingStartCombatPacket = 0xFE27,
            ExFishingHpRegenPacket = 0xFE28,
            ExEnchantSkillListPacket = 0xFE29,
            ExEnchantSkillInfoPacket = 0xFE2A,
            ExShowCropSettingPacket = 0xFE2B,
            ExShowSellCropListPacket = 0xFE2C,
            ExOlympiadMatchEndPacket = 0xFE2D,
            ExMailArrivedPacket = 0xFE2E,
            ExStorageMaxCountPacket = 0xFE2F,
            ExEventMatchManagePacket = 0xFE30,
            ExMultiPartyCommandChannelInfoPacket = 0xFE31,
            ExPCCafePointInfoPacket = 0xFE32,
            ExSetCompassZoneCode = 0xFE33,
            ExGetBossRecord = 0xFE34,
            ExAskJoinPartyRoom = 0xFE35,
            ExListPartyMatchingWaitingRoom = 0xFE36,
            ExSetMpccRouting = 0xFE37,
            ExShowAdventurerGuideBook = 0xFE38,
            ExShowScreenMessage = 0xFE39,
            PledgeSkillListPacket = 0xFE3A,
            PledgeSkillListAddPacket = 0xFE3B,
            PledgePowerGradeList = 0xFE3C,
            PledgeReceivePowerInfo = 0xFE3D,
            PledgeReceiveMemberInfo = 0xFE3E,
            PledgeReceiveWarList = 0xFE3F,
            PledgeReceiveSubPledgeCreated = 0xFE40,
            ExRedSkyPacket = 0xFE41,
            PledgeReceiveUpdatePower = 0xFE42,
            FlySelfDestinationPacket = 0xFE43,
            ShowPCCafeCouponShowUI = 0xFE44,
            ExSearchOrc = 0xFE45,
            ExCursedWeaponList = 0xFE46,
            ExCursedWeaponLocation = 0xFE47,
            ExRestartClient = 0xFE48,
            ExRequestHackShield = 0xFE49,
            ExUseSharedGroupItem = 0xFE4A,
            ExMPCCShowPartyMemberInfo = 0xFE4B,
            ExDuelAskStart = 0xFE4C,
            ExDuelReady = 0xFE4D,
            ExDuelStart = 0xFE4E,
            ExDuelEnd = 0xFE4F,
            ExDuelUpdateUserInfo = 0xFE50,
            ExShowVariationMakeWindow = 0xFE51,
            ExShowVariationCancelWindow = 0xFE52,
            ExPutItemResultForVariationMake = 0xFE53,
            ExPutIntensiveResultForVariationMake = 0xFE54,
            ExPutCommissionResultForVariationMake = 0xFE55,
            ExVariationResult = 0xFE56,
            ExPutItemResultForVariationCancel = 0xFE57,
            ExVariationCancelResult = 0xFE58,
            ExDuelEnemyRelation = 0xFE59,
            ExPlayAnimation = 0xFE5A,
            ExMPCCPartyInfoUpdate = 0xFE5B,
            ExPlayScene = 0xFE5C,
            ExSpawnEmitterPacket = 0xFE5D,
            ExEnchantSkillInfoDetailPacket = 0xFE5E,
            ExBasicActionList = 0xFE5F,
            ExAirShipInfo = 0xFE60,
            ExAttributeEnchantResultPacket = 0xFE61,
            ExChooseInventoryAttributeItemPacket = 0xFE62,
            ExGetOnAirShipPacket = 0xFE63,
            ExGetOffAirShipPacket = 0xFE64,
            ExMoveToLocationAirShipPacket = 0xFE65,
            ExStopMoveAirShipPacket = 0xFE66,
            ExShowTracePacket = 0xFE67,
            ExItemAuctionInfoPacket = 0xFE68,
            ExNeedToChangeName = 0xFE69,
            ExPartyPetWindowDelete = 0xFE6A,
            ExTutorialList = 0xFE6B,
            ExRpItemLink = 0xFE6C,
            ExMoveToLocationInAirShipPacket = 0xFE6D,
            ExStopMoveInAirShipPacket = 0xFE6E,
            ExValidateLocationInAirShipPacket = 0xFE6F,
            ExUISettingPacket = 0xFE70,
            ExMoveToTargetInAirShipPacket = 0xFE71,
            ExAttackInAirShipPacket = 0xFE72,
            ExMagicSkillUseInAirShipPacket = 0xFE73,
            ExShowBaseAttributeCancelWindow = 0xFE74,
            ExBaseAttributeCancelResult = 0xFE75,
            ExSubPledgetSkillAdd = 0xFE76,
            ExResponseFreeServer = 0xFE77,
            ExShowProcureCropDetailPacket = 0xFE78,
            ExHeroListPacket = 0xFE79,
            ExOlympiadUserInfoPacket = 0xFE7A,
            ExOlympiadSpelledInfoPacket = 0xFE7B,
            ExOlympiadModePacket = 0xFE7C,
            ExShowFortressMapInfo = 0xFE7D,
            ExPVPMatchRecord = 0xFE7E,
            ExPVPMatchUserDie = 0xFE7F,
            ExPrivateStoreSetWholeMsg = 0xFE80,
            ExPutEnchantTargetItemResult = 0xFE81,
            ExPutEnchantSupportItemResult = 0xFE82,
            ExChangeNicknameNColor = 0xFE83,
            ExGetBookMarkInfoPacket = 0xFE84,
            ExNotifyPremiumItem = 0xFE85,
            ExGetPremiumItemListPacket = 0xFE86,
            ExPeriodicItemList = 0xFE87,
            ExJumpToLocation = 0xFE88,
            ExPVPMatchCCRecord = 0xFE89,
            ExPVPMatchCCMyRecord = 0xFE8A,
            ExPVPMatchCCRetire = 0xFE8B,
            ExShowTerritory = 0xFE8C,
            ExNpcQuestHtmlMessage = 0xFE8D,
            ExSendUIEventPacket = 0xFE8E,
            ExNotifyBirthDay = 0xFE8F,
            ExShowDominionRegistry = 0xFE90,
            ExReplyRegisterDominion = 0xFE91,
            ExReplyDominionInfo = 0xFE92,
            ExShowOwnthingPos = 0xFE93,
            ExCleftList = 0xFE94,
            ExCleftState = 0xFE95,
            ExDominionChannelSet = 0xFE96,
            ExBlockUpSetList = 0xFE97,
            ExBlockUpSetState = 0xFE98,
            ExStartScenePlayer = 0xFE99,
            ExAirShipTeleportList = 0xFE9A,
            ExMpccRoomInfo = 0xFE9B,
            ExListMpccWaiting = 0xFE9C,
            ExDissmissMpccRoom = 0xFE9D,
            ExManageMpccRoomMember = 0xFE9E,
            ExMpccRoomMember = 0xFE9F,
            ExVitalityPointInfo = 0xFEA0,
            ExShowSeedMapInfo = 0xFEA1,
            ExMpccPartymasterList = 0xFEA2,
            ExDominionWarStart = 0xFEA3,
            ExDominionWarEnd = 0xFEA4,
            ExShowLines = 0xFEA5,
            ExPartyMemberRenamed = 0xFEA6,
            ExEnchantSkillResult = 0xFEA7,
            ExRefundList = 0xFEA8,
            ExNoticePostArrived = 0xFEA9,
            ExShowReceivedPostList = 0xFEAA,
            ExReplyReceivedPost = 0xFEAB,
            ExShowSentPostList = 0xFEAC,
            ExReplySentPost = 0xFEAD,
            ExResponseShowStepOne = 0xFEAE,
            ExResponseShowStepTwo = 0xFEAF,
            ExResponseShowContents = 0xFEB0,
            ExShowPetitionHtml = 0xFEB1,
            ExReplyPostItemList = 0xFEB2,
            ExChangePostState = 0xFEB3,
            ExReplyWritePost = 0xFEB4,
            ExRaidCharSelected = 0xFEB5,
            ExRaidReserveResult = 0xFEB6,
            ExBuySellListPacket = 0xFEB7,

ExBR_GamePoint = 0xFEB8,
ExBR_ProductList = 0xFEB9,
ExBR_ProductInfo = 0xFEBA,
ExBR_BuyProduct = 0xFEBB,
ExBR_PremiumState = 0xFEBC,
ExBrBroadcastEventState = 0xFEBD,
ExBrExtraUserInfo = 0xFEBE,
ExBrBuffEventState = 0xFEBF,
ExBR_RecentProductList = 0xFEC0,
ExBR_LoadEventTopRankers = 0xFEC1,
ExBR_MinigameLoadScores = 0xFEC2,
        }
        public enum Client : int
        {
            Logout = 0x00,
            Attack = 0x01,
            RequestStartPledgeWar = 0x03,
            RequestReplyStartPledgeWar = 0x04,
            RequestStopPledgeWar = 0x05,
            RequestSCCheck = 0x06,
            RequestSurrenderPledgeWar = 0x07,
            RequestReplySurrenderPledgeWar = 0x08,
            RequestSetPledgeCrest = 0x09,
            RequestGiveNickName = 0x0b,
            NewCharacter = 0x0c,
            CharacterDeletePacket = 0x0d,
            ProtocolVersion = 0x0e,
            MoveBackwardToLocation = 0x0f,
            Say = 0x10,
            EnterWorld = 0x11,
            CharacterSelect = 0x12,
            NewCharacterPacket = 0x13,
            ItemList = 0x14,
            RequestEquipItem = 0x15,
            RequestUnEquipItem = 0x16,
            RequestDropItemPacket = 0x17,
            UseItemPacket = 0x19,
            TradeRequestPacket = 0x1a,
            AddTradeItemPacket = 0x1b,
            TradeDonePacket = 0x1c,
            Action = 0x1f,
            RequestLinkHtml = 0x22,
            RequestBypassToServer = 0x23,
            RequestBBSWrite = 0x24,
            RequestCreatePledge = 0x25,
            RequestJoinPledge = 0x26,
            RequestAnswerJoinPledge = 0x27,
            RequestWithDrawalPledge = 0x28,
            RequestOustPledgeMember = 0x29,
            AuthLogin = 0x2b,
            RequestGetItemFromPet = 0x2c,
            RequestAllyInfo = 0x2e,
            RequestCrystallizeItem = 0x2f,
            RequestPrivateStoreManageSell = 0x30,
            SetPrivateStoreList = 0x31,
            AttackRequest = 0x32,
            RequestTeleportPacket = 0x33,
            SocialAction = 0x34,
            ChangeMoveType = 0x35,
            ChangeWaitType = 0x36,
            RequestSellItem = 0x37,
            RequestMagicSkillList = 0x38,
            RequestMagicSkillUse = 0x39,
            SendApperingPacket = 0x3a,
            SendWareHouseDepositList = 0x3b,
            SendWareHouseWithDrawList = 0x3c,
            RequestShortCutReg = 0x3d,
            RequestShortCutUse = 0x3e,
            RequestShortCutDel = 0x3f,
            RequestBuyItem = 0x40,
            RequestDismissPledge = 0x41,
            RequestJoinParty = 0x42,
            RequestAnswerJoinParty = 0x43,
            RequestWithDrawalParty = 0x44,
            RequestOustPartyMember = 0x45,
            RequestDismissParty = 0x46,
            CanNotMoveAnymore = 0x47,
            RequestTargetCancel = 0x48,
            Say2 = 0x49,
            RequestPledgeMemberList = 0x4d,
            RequestMagicList = 0x4f,
            RequestSkillList = 0x50,
            MoveWithDelta = 0x52,
            GetOnVehicle = 0x53,
            GetOffVehicle = 0x54,
            AnswerTradeRequest = 0x55,
            RequestActionUse = 0x56,
            RequestRestart = 0x57,
            RequestSiegeInfo = 0x58,
            ValidatePosition = 0x59,
            RequestSEKCustom = 0x5a,
            StartRotating = 0x5b,
            FinishRotating = 0x5c,
            RequestShowboard = 0x5e,
            RequestEnchantItem = 0x5f,
            RequestDestroyItem = 0x60,
            RequestQuestList = 0x62,
            RequestDestroyQuest = 0x63,
            RequestPledgeInfo = 0x65,
            RequestPledgeExtendedInfo = 0x66,
            RequestPledgeCrest = 0x67,
            RequestSendL2FriendSay = 0x6b,
            RequestOpenMinimap = 0x6c,
            RequestSendMsnChatLog = 0x6d,
            RequestReload = 0x6e,
            RequestHennaEquip = 0x6f,
            RequestHennaUnequipList = 0x70,
            RequestHennaUnequipInfo = 0x71,
            RequestHennaUnequip = 0x72,
            RequestAcquireSkillInfo = 0x73,
            SendBypassBuildCmd = 0x74,
            MoveToLocationInVehicle = 0x75,
            CanNotMoveAnymoreVehicle = 0x76,
            RequestFriendInvite = 0x77,
            RequestFriendAddReply = 0x78,
            RequestFriendList = 0x79,
            RequestFriendDel = 0x7a,
            CharacterRestorePacket = 0x7b,
            RequestAcquireSkill = 0x7c,
            RequestRestartPoint = 0x7d,
            RequestGMCommand = 0x7e,
            RequestPartyMatchConfig = 0x7f,
            RequestPartyMatchList = 0x80,
            RequestPartyMatchDetail = 0x81,
            SendPrivateStoreBuyList = 0x83,
            ReviveReply = 0x84,
            RequestTutorialLinkHtml = 0x85,
            RequestTutorialPassCmdToServer = 0x86,
            RequestTutorialQuestionMarkPressed = 0x87,
            RequestTutorialClientEvent = 0x88,
            RequestPetition = 0x89,
            RequestPetitionCancel = 0x8a,
            RequestGMList = 0x8b,
            RequestJoinAlly = 0x8c,
            RequestAnswerJoinAlly = 0x8d,
            RequestWithdrawAlly = 0x8e,
            RequestOustAlly = 0x8f,
            RequestDismissAlly = 0x90,
            RequestSetAllyCrest = 0x91,
            RequestAllyCrest = 0x92,
            RequestChangePetName = 0x93,
            RequestPetUseItem = 0x94,
            RequestGiveItemToPet = 0x95,
            RequestPrivateStoreQuitSell = 0x96,
            SetPrivateStoreMsgSell = 0x97,
            RequestPetGetItem = 0x98,
            RequestPrivateStoreBuyManage = 0x99,
            //SetPrivateStoreList = 0x9a,
            RequestPrivateStoreQuitBuy = 0x9c,
            SetPrivateStoreMsgBuy = 0x9d,
            //SendPrivateStoreBuyList = 0x9f,
            SendTimeCheckPacket = 0xa0,
            RequestSkillCoolTime = 0xa6,
            RequestPackageSendableItemList = 0xa7,
            RequestPackageSend = 0xa8,
            RequestBlock = 0xa9,
            RequestCastleSiegeInfo = 0xaa,
            RequestCastleSiegeAttackerList = 0xab,
            //RequestCastleSiegeInfo = 0xac,
            RequestJoinCastleSiege = 0xad,
            RequestConfirmCastleSiegeWaitingList = 0xae,
            RequestSetCastleSiegeTime = 0xaf,
            RequestMultiSellChoose = 0xb0,
            NetPing = 0xb1,
            RequestRemainTime = 0xb2,
            BypassUserCmd = 0xb3,
            Snoop = 0xb4,
            RequestRecipeBookOpen = 0xb5,
            RequestRecipeItemDelete = 0xb6,
            RequestRecipeItemMakeInfo = 0xb7,
            RequestRecipeItemMakeSelf = 0xb8,
            RequestRecipeShopManageList = 0xb9,
            RequestRecipeShopMessageSet = 0xba,
            RequestRecipeShopListSet = 0xbb,
            RequestRecipeShopManageQuit = 0xbc,
            RequestRecipeShopManageCancel = 0xbd,
            RequestRecipeShopMakeInfo = 0xbe,
            RequestRecipeShopMakeDo = 0xbf,
            RequestRecipeShopSellList = 0xc0,
            RequestObserverEndPacket = 0xc1,
            VoteSociality = 0xc2,
            RequestHennaItemList = 0xc3,
            RequestHennaItemInfo = 0xc4,
            RequestBuySeed = 0xc5,
            ConfirmDlg = 0xc6,
            RequestPreviewItem = 0xc7,
            RequestSSQStatus = 0xc8,
            PetitionVote = 0xc9,
            ReplyGameGuardQuery = 0xcb,
            RequestPledgePower = 0xcc,
            RequestMakeMacro = 0xcd,
            RequestDeleteMacro = 0xce,
            RequestProcureCrop = 0xcf,
            DummyPacket =0xD0,
            RequestManorList = 0xD001,
            RequestProcureCropList = 0xD002,
            RequestSetSeed = 0xD003,
            RequestSetCrop = 0xD004,
            RequestWriteHeroWords = 0xD005,
            RequestExAskJoinMPCC = 0xD006,
            RequestExAcceptJoinMPCC = 0xD007,
            RequestExOustFromMPCC = 0xD008,
            RequestOustFromPartyRoom = 0xD009,
            RequestDismissPartyRoom = 0xD00a,
            RequestWithdrawPartyRoom = 0xD00b,
            RequestHandOverPartyMaster = 0xD00c,
            RequestAutoSoulShot = 0xD00d,
            RequestExEnchantSkillInfo = 0xD00e,
            RequestExEnchantSkill = 0xD00f,
            RequestExPledgeCrestLarge = 0xD010,
            RequestExSetPledgeCrestLarge = 0xD011,
            RequestPledgeSetAcademyMaster = 0xD012,
            RequestPledgePowerGradeList = 0xD013,
            RequestPledgeMemberPowerInfo = 0xD014,
            RequestPledgeSetMemberPowerGrade = 0xD015,
            RequestPledgeMemberInfo = 0xD016,
            RequestPledgeWarList = 0xD017,
            RequestExFishRanking = 0xD018,
            RequestPCCafeCouponUse = 0xD019,
            ExOrcMove = 0xD01a,
            RequestDuelStart = 0xD01b,
            RequestDuelAnswerStart = 0xD01c,
            RequestExSetTutorial = 0xD01d,
            RequestExRqItemLink = 0xD01e,
            CanNotMoveAnymoreAirShip = 0xD01f,
            MoveToLocationInAirShip = 0xD020,
            RequestKeyMapping = 0xD021,
            RequestSaveKeyMapping = 0xD022,
            RequestExRemoveItemAttribute = 0xD023,
            RequestSaveInventoryOrder = 0xD024,
            RequestExitPartyMatchingWaitingRoom = 0xD025,
            RequestConfirmTargetItem = 0xD026,
            RequestConfirmRefinerItem = 0xD027,
            RequestConfirmGemStone = 0xD028,
            RequestOlympiadObserverEnd = 0xD029,
            RequestCursedWeaponList = 0xD02a,
            RequestCursedWeaponLocation = 0xD02b,
            RequestPledgeReorganizeMember = 0xD02c,
            RequestExMPCCShowPartyMembersInfo = 0xD02d,
            RequestOlympiadMatchList = 0xD02e,
            RequestAskJoinPartyRoom = 0xD02f,
            AnswerJoinPartyRoom = 0xD030,
            RequestListPartyMatchingWaitingRoom = 0xD031,
            RequestEnchantItemAttribute = 0xD035,
            ExGetOnAirShip = 0xD036,
            MoveToLocationAirShip = 0xD038,
            RequestBidItemAuction = 0xD039,
            RequestInfoItemAuction = 0xD03a,
            RequestExChangeName = 0xD03b,
            RequestAllCastleInfo = 0xD03c,
            RequestAllFortressInfo = 0xD03d,
            RequestAllAgitInfo = 0xD03e,
            RequestFortressSiegeInfo = 0xD03f,
            RequestGetBossRecord = 0xD040,
            RequestRefine = 0xD041,
            RequestConfirmCancelItem = 0xD042,
            RequestRefineCancel = 0xD043,
            RequestExMagicSkillUseGround = 0xD044,
            RequestDuelSurrender = 0xD045,
            RequestExEnchantSkillInfoDetail = 0xD046,
            RequestFortressMapInfo = 0xD048,
            RequestPVPMatchRecord = 0xD049,
            SetPrivateStoreWholeMsg = 0xD04a,
            RequestDispel = 0xD04b,
            RequestExTryToPutEnchantTargetItem = 0xD04c,
            RequestExTryToPutEnchantSupportItem = 0xD04d,
            RequestExCancelEnchantItem = 0xD04e,
            RequestChangeNicknameColor = 0xD04f,
            RequestResetNickname = 0xD050,
            RequestWithDrawPremiumItem = 0xD052,
            RequestJump = 0xD053,
            RequestStartShowCrataeCubeRank = 0xD054,
            RequestStopShowCrataeCubeRank = 0xD055,
            NotifyStartMiniGame = 0xD056,
            RequestJoinDominionWar = 0xD057,
            RequestDominionInfo = 0xD058,
            RequestExCleftEnter = 0xD059,
            RequestExBlockGameEnter = 0xD05a,
            EndScenePlayer = 0xD05b,
            RequestExBlockGameVote = 0xD05c,
            RequestListMpccWaiting = 0xD05d,
            RequestManageMpccRoom = 0xD05e,
            RequestJoinMpccRoom = 0xD05f,
            RequestOustFromMpccRoom = 0xD060,
            RequestDismissMpccRoom = 0xD061,
            RequestWithdrawMpccRoom = 0xD062,
            RequestSeedPhase = 0xD063,
            RequestMpccPartyMasterList = 0xD064,
            RequestPostItemList = 0xD065,
            RequestSendPost = 0xD066,
            RequestRequestReceivedPostList = 0xD067,
            RequestDeleteReceivedPost = 0xD068,
            RequestRequestReceivedPost = 0xD069,
            RequestReceivePost = 0xD06a,
            RequestRejectPost = 0xD06b,
            RequestSentPostList = 0xD06c,
            RequestDeleteSentPost = 0xD06d,
            RequestRequestSentPost = 0xD06e,
            RequestCancelSentPost = 0xD06f,
            RequestShowNewUserPetition = 0xD070,
            RequestShowStepThree = 0xD071,
            RequestShowStepTwo = 0xD072,
            ExRaidReserveResult = 0xD073,
            RequestRefundItem = 0xD075,
            RequestBuySellUIClose = 0xD076,
            RequestEventMatchObserverEnd = 0xD077,
            BrGamePoint = 0xD078,
            BrProductList = 0xD079,
            BrProductInfo = 0xD07a,
            BrBuyProduct = 0xD07b,
            BrRecentProductList = 0xD07c,
            BrEventRankerList = 0xD07d,
            BrMinigameLoadScores = 0xD07e,
            BrMinigameInsertScore = 0xD07f,
            BrLectureMark = 0xD080,
        }
    }
}