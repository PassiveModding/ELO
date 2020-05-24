﻿// <auto-generated />
using System;
using ELO.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ELO.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20200524044714_DeletedPremiumuser")]
    partial class DeletedPremiumuser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("ELO.CompetitionModels.Legacy.Token", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("text");

                    b.Property<int>("Days")
                        .HasColumnType("integer");

                    b.HasKey("Key");

                    b.ToTable("LegacyTokens");
                });

            modelBuilder.Entity("ELO.Models.Ban", b =>
                {
                    b.Property<int>("BanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<decimal>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<TimeSpan>("Length")
                        .HasColumnType("interval");

                    b.Property<bool>("ManuallyDisabled")
                        .HasColumnType("boolean");

                    b.Property<decimal>("Moderator")
                        .HasColumnType("numeric(20,0)");

                    b.Property<DateTime>("TimeOfBan")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal>("UserId")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("BanId");

                    b.HasIndex("GuildId");

                    b.ToTable("Bans");
                });

            modelBuilder.Entity("ELO.Models.CommandPermission", b =>
                {
                    b.Property<decimal>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("CommandName")
                        .HasColumnType("text");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.HasKey("GuildId", "CommandName");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("ELO.Models.Competition", b =>
                {
                    b.Property<decimal>("GuildId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal?>("AdminRole")
                        .HasColumnType("numeric(20,0)");

                    b.Property<bool>("AllowMultiQueueing")
                        .HasColumnType("boolean");

                    b.Property<bool>("AllowNegativeScore")
                        .HasColumnType("boolean");

                    b.Property<bool>("AllowReRegister")
                        .HasColumnType("boolean");

                    b.Property<bool>("AllowSelfRename")
                        .HasColumnType("boolean");

                    b.Property<bool>("AllowVoting")
                        .HasColumnType("boolean");

                    b.Property<int?>("BufferedPremiumCount")
                        .HasColumnType("integer");

                    b.Property<int>("DefaultLossModifier")
                        .HasColumnType("integer");

                    b.Property<int>("DefaultRegisterScore")
                        .HasColumnType("integer");

                    b.Property<int>("DefaultWinModifier")
                        .HasColumnType("integer");

                    b.Property<bool>("DisplayErrors")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LegacyPremiumExpiry")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ManualGameCounter")
                        .HasColumnType("integer");

                    b.Property<decimal?>("ModeratorRole")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("NameFormat")
                        .HasColumnType("text");

                    b.Property<string>("Prefix")
                        .HasColumnType("text");

                    b.Property<DateTime?>("PremiumBuffer")
                        .HasColumnType("timestamp without time zone");

                    b.Property<decimal?>("PremiumRedeemer")
                        .HasColumnType("numeric(20,0)");

                    b.Property<TimeSpan?>("QueueTimeout")
                        .HasColumnType("interval");

                    b.Property<decimal?>("ReactiveMessage")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("RegisterMessageTemplate")
                        .HasColumnType("text");

                    b.Property<decimal?>("RegisteredRankId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<TimeSpan?>("RequeueDelay")
                        .HasColumnType("interval");

                    b.Property<bool>("UpdateNames")
                        .HasColumnType("boolean");

                    b.HasKey("GuildId");

                    b.ToTable("Competitions");
                });

            modelBuilder.Entity("ELO.Models.GameResult", b =>
                {
                    b.Property<decimal>("LobbyId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("GameId")
                        .HasColumnType("integer");

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("GamePickMode")
                        .HasColumnType("integer");

                    b.Property<int>("GameState")
                        .HasColumnType("integer");

                    b.Property<decimal>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("MapName")
                        .HasColumnType("text");

                    b.Property<int>("PickOrder")
                        .HasColumnType("integer");

                    b.Property<int>("Picks")
                        .HasColumnType("integer");

                    b.Property<decimal>("Submitter")
                        .HasColumnType("numeric(20,0)");

                    b.Property<bool>("VoteComplete")
                        .HasColumnType("boolean");

                    b.Property<int>("WinningTeam")
                        .HasColumnType("integer");

                    b.HasKey("LobbyId", "GameId");

                    b.HasIndex("GuildId");

                    b.ToTable("GameResults");
                });

            modelBuilder.Entity("ELO.Models.GameVote", b =>
                {
                    b.Property<decimal>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("ChannelId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("UserId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("GameId")
                        .HasColumnType("integer");

                    b.Property<int>("UserVote")
                        .HasColumnType("integer");

                    b.HasKey("GuildId", "ChannelId", "UserId", "GameId");

                    b.HasIndex("ChannelId", "GameId");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("ELO.Models.Lobby", b =>
                {
                    b.Property<decimal>("ChannelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("CaptainPickOrder")
                        .HasColumnType("integer");

                    b.Property<int>("CurrentGameCount")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("DmUsersOnGameReady")
                        .HasColumnType("boolean");

                    b.Property<decimal?>("GameReadyAnnouncementChannel")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal?>("GameResultAnnouncementChannel")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<bool>("HideQueue")
                        .HasColumnType("boolean");

                    b.Property<int?>("HighLimit")
                        .HasColumnType("integer");

                    b.Property<int>("HostSelectionMode")
                        .HasColumnType("integer");

                    b.Property<double>("LobbyMultiplier")
                        .HasColumnType("double precision");

                    b.Property<bool>("MentionUsersInReadyAnnouncement")
                        .HasColumnType("boolean");

                    b.Property<int?>("MinimumPoints")
                        .HasColumnType("integer");

                    b.Property<bool>("MultiplyLossValue")
                        .HasColumnType("boolean");

                    b.Property<int>("PlayersPerTeam")
                        .HasColumnType("integer");

                    b.Property<double>("ReductionPercent")
                        .HasColumnType("double precision");

                    b.Property<int>("TeamPickMode")
                        .HasColumnType("integer");

                    b.HasKey("ChannelId");

                    b.HasIndex("GuildId");

                    b.ToTable("Lobbies");
                });

            modelBuilder.Entity("ELO.Models.ManualGameResult", b =>
                {
                    b.Property<decimal>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("GameId")
                        .HasColumnType("integer");

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("GameState")
                        .HasColumnType("integer");

                    b.Property<decimal>("Submitter")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("GuildId", "GameId");

                    b.ToTable("ManualGameResults");
                });

            modelBuilder.Entity("ELO.Models.ManualGameScoreUpdate", b =>
                {
                    b.Property<decimal>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("ManualGameId")
                        .HasColumnType("integer");

                    b.Property<decimal>("UserId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("ModifyAmount")
                        .HasColumnType("integer");

                    b.HasKey("GuildId", "ManualGameId", "UserId");

                    b.ToTable("ManualGameScoreUpdates");
                });

            modelBuilder.Entity("ELO.Models.Map", b =>
                {
                    b.Property<decimal>("ChannelId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<string>("MapName")
                        .HasColumnType("text");

                    b.HasKey("ChannelId", "MapName");

                    b.ToTable("Maps");
                });

            modelBuilder.Entity("ELO.Models.PartyMember", b =>
                {
                    b.Property<decimal>("ChannelId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("UserId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("PartyHost")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("ChannelId", "UserId");

                    b.HasIndex("GuildId");

                    b.ToTable("PartyMembers");
                });

            modelBuilder.Entity("ELO.Models.Player", b =>
                {
                    b.Property<decimal>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("UserId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("Deaths")
                        .HasColumnType("integer");

                    b.Property<string>("DisplayName")
                        .HasColumnType("text");

                    b.Property<int>("Draws")
                        .HasColumnType("integer");

                    b.Property<int>("Kills")
                        .HasColumnType("integer");

                    b.Property<int>("Losses")
                        .HasColumnType("integer");

                    b.Property<int>("Points")
                        .HasColumnType("integer");

                    b.Property<DateTime>("RegistrationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Wins")
                        .HasColumnType("integer");

                    b.HasKey("GuildId", "UserId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("ELO.Models.QueuedPlayer", b =>
                {
                    b.Property<decimal>("ChannelId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("UserId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<DateTime>("QueuedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("ChannelId", "UserId");

                    b.HasIndex("GuildId");

                    b.ToTable("QueuedPlayers");
                });

            modelBuilder.Entity("ELO.Models.Rank", b =>
                {
                    b.Property<decimal>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<int?>("LossModifier")
                        .HasColumnType("integer");

                    b.Property<int>("Points")
                        .HasColumnType("integer");

                    b.Property<int?>("WinModifier")
                        .HasColumnType("integer");

                    b.HasKey("RoleId");

                    b.HasIndex("GuildId");

                    b.ToTable("Ranks");
                });

            modelBuilder.Entity("ELO.Models.ScoreUpdate", b =>
                {
                    b.Property<decimal>("ChannelId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("UserId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("GameNumber")
                        .HasColumnType("integer");

                    b.Property<decimal>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("ModifyAmount")
                        .HasColumnType("integer");

                    b.HasKey("ChannelId", "UserId", "GameNumber");

                    b.HasIndex("GuildId");

                    b.HasIndex("ChannelId", "GameNumber");

                    b.ToTable("ScoreUpdates");
                });

            modelBuilder.Entity("ELO.Models.TeamCaptain", b =>
                {
                    b.Property<decimal>("ChannelId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("GameNumber")
                        .HasColumnType("integer");

                    b.Property<int>("TeamNumber")
                        .HasColumnType("integer");

                    b.Property<decimal>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("UserId")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("ChannelId", "GameNumber", "TeamNumber");

                    b.ToTable("TeamCaptains");
                });

            modelBuilder.Entity("ELO.Models.TeamPlayer", b =>
                {
                    b.Property<decimal>("ChannelId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<decimal>("UserId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("GameNumber")
                        .HasColumnType("integer");

                    b.Property<int>("TeamNumber")
                        .HasColumnType("integer");

                    b.Property<decimal>("GuildId")
                        .HasColumnType("numeric(20,0)");

                    b.HasKey("ChannelId", "UserId", "GameNumber", "TeamNumber");

                    b.HasIndex("GuildId");

                    b.HasIndex("ChannelId", "GameNumber");

                    b.ToTable("TeamPlayers");
                });

            modelBuilder.Entity("ELO.Services.Premium.DeletedPremiumUser", b =>
                {
                    b.Property<decimal>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("EntitledRegistrationCount")
                        .HasColumnType("integer");

                    b.Property<decimal>("EntitledRoleId")
                        .HasColumnType("numeric(20,0)");

                    b.Property<DateTime>("LastSuccessfulKnownPayment")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("UserId");

                    b.ToTable("DeletedPremiumUsers");
                });

            modelBuilder.Entity("ELO.Services.PremiumService+PremiumRole", b =>
                {
                    b.Property<decimal>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("numeric(20,0)");

                    b.Property<int>("Limit")
                        .HasColumnType("integer");

                    b.HasKey("RoleId");

                    b.ToTable("PremiumRoles");
                });

            modelBuilder.Entity("ELO.Models.Ban", b =>
                {
                    b.HasOne("ELO.Models.Competition", "Competition")
                        .WithMany()
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ELO.Models.CommandPermission", b =>
                {
                    b.HasOne("ELO.Models.Competition", "Competition")
                        .WithMany()
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ELO.Models.GameResult", b =>
                {
                    b.HasOne("ELO.Models.Competition", "Competition")
                        .WithMany()
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ELO.Models.Lobby", "Lobby")
                        .WithMany("GameResults")
                        .HasForeignKey("LobbyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ELO.Models.GameVote", b =>
                {
                    b.HasOne("ELO.Models.Lobby", "Lobby")
                        .WithMany()
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ELO.Models.Competition", "Competition")
                        .WithMany()
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ELO.Models.GameResult", "Game")
                        .WithMany("Votes")
                        .HasForeignKey("ChannelId", "GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ELO.Models.Lobby", b =>
                {
                    b.HasOne("ELO.Models.Competition", "Competition")
                        .WithMany("Lobbies")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ELO.Models.ManualGameResult", b =>
                {
                    b.HasOne("ELO.Models.Competition", "Comp")
                        .WithMany("ManualGames")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ELO.Models.ManualGameScoreUpdate", b =>
                {
                    b.HasOne("ELO.Models.Competition", "Comp")
                        .WithMany()
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ELO.Models.ManualGameResult", "Game")
                        .WithMany("ScoreUpdates")
                        .HasForeignKey("GuildId", "ManualGameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ELO.Models.Map", b =>
                {
                    b.HasOne("ELO.Models.Lobby", "Lobby")
                        .WithMany("Maps")
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ELO.Models.PartyMember", b =>
                {
                    b.HasOne("ELO.Models.Lobby", "Lobby")
                        .WithMany()
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ELO.Models.Competition", "Competition")
                        .WithMany()
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ELO.Models.Player", b =>
                {
                    b.HasOne("ELO.Models.Competition", "Competition")
                        .WithMany("Players")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ELO.Models.QueuedPlayer", b =>
                {
                    b.HasOne("ELO.Models.Lobby", "Lobby")
                        .WithMany("Queue")
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ELO.Models.Competition", "Competition")
                        .WithMany()
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ELO.Models.Rank", b =>
                {
                    b.HasOne("ELO.Models.Competition", "Competition")
                        .WithMany("Ranks")
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ELO.Models.ScoreUpdate", b =>
                {
                    b.HasOne("ELO.Models.Lobby", "Lobby")
                        .WithMany()
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ELO.Models.Competition", "Comp")
                        .WithMany()
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ELO.Models.GameResult", "Game")
                        .WithMany("ScoreUpdates")
                        .HasForeignKey("ChannelId", "GameNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ELO.Models.TeamCaptain", b =>
                {
                    b.HasOne("ELO.Models.Lobby", "Lobby")
                        .WithMany()
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ELO.Models.GameResult", "Game")
                        .WithMany("Captains")
                        .HasForeignKey("ChannelId", "GameNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ELO.Models.TeamPlayer", b =>
                {
                    b.HasOne("ELO.Models.Lobby", "Lobby")
                        .WithMany()
                        .HasForeignKey("ChannelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ELO.Models.Competition", "Comp")
                        .WithMany()
                        .HasForeignKey("GuildId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ELO.Models.GameResult", "Game")
                        .WithMany("TeamPlayers")
                        .HasForeignKey("ChannelId", "GameNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
