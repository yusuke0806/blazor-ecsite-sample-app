﻿// <auto-generated />
using BlazorECSiteSample.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorECSiteSample.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorECSiteSample.Shared.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "PlayFab の勉強を始めるにあたって、どこからどういった順番で学習をしていくのかがわからないと思います。いろんな機能がある中で、難しい機能から始めてしまうと、理解が難しくやめてしまう原因にもなります。そこで本書では、理解がしやすい以下の機能をピックアップして、入門編としました。",
                            ImageUrl = "https://raw.githubusercontent.com/nekojoker/sample-contents/main/images/1.png",
                            Title = "猫でもわかるPlayFab入門",
                            UnitPrice = 1000m
                        },
                        new
                        {
                            Id = 2,
                            Description = "PlayFabを使いこなす上で自動化まわりの機能の理解は欠かせません。しかしながら、自動化まわりの機能は便利ですが学習コストが高く、なかなか手を出しにくい分野であることも事実です。",
                            ImageUrl = "https://raw.githubusercontent.com/nekojoker/sample-contents/main/images/2.png",
                            Title = "猫でもわかるPlayFab自動化編",
                            UnitPrice = 1100m
                        },
                        new
                        {
                            Id = 3,
                            Description = "フレンド機能やドロップテーブルなど、ソーシャルまわりの機能の使い方を１冊にまとめました。",
                            ImageUrl = "https://raw.githubusercontent.com/nekojoker/sample-contents/main/images/3.png",
                            Title = "猫でもわかるPlayFabソーシャル編",
                            UnitPrice = 1200m
                        },
                        new
                        {
                            Id = 4,
                            Description = "本書は、PlayFabを使って実際にリリースしたい人に向けて執筆しました。公式ドキュメントからは読み取りにくい内容についても、独自に調べて解説をしています。",
                            ImageUrl = "https://raw.githubusercontent.com/nekojoker/sample-contents/main/images/4.png",
                            Title = "猫でもわかるPlayFab運用編",
                            UnitPrice = 1300m
                        },
                        new
                        {
                            Id = 5,
                            Description = "「世の中に情報が出ていないのであれば、自分で試してまとめるしかない」と思い、本書の執筆にいたりました。本書を読むことで、次の内容を理解することができます。",
                            ImageUrl = "https://raw.githubusercontent.com/nekojoker/sample-contents/main/images/9.png",
                            Title = "猫でもわかるPlayFabUGC編",
                            UnitPrice = 1400m
                        },
                        new
                        {
                            Id = 6,
                            Description = "Blazorの基礎を勉強できます。",
                            ImageUrl = "https://raw.githubusercontent.com/nekojoker/sample-contents/main/images/7.png",
                            Title = "猫でもわかるBlazor入門",
                            UnitPrice = 1500m
                        },
                        new
                        {
                            Id = 7,
                            Description = "Blazorで認証付きのCRUDアプリがつくれるようになります。",
                            ImageUrl = "https://raw.githubusercontent.com/nekojoker/sample-contents/main/images/8.png",
                            Title = "猫でもわかるBlazor実践編",
                            UnitPrice = 1600m
                        },
                        new
                        {
                            Id = 8,
                            Description = "Backendlessの無料プランを開放することができます。",
                            ImageUrl = "https://raw.githubusercontent.com/nekojoker/sample-contents/main/images/5.png",
                            Title = "猫でもわかるBackendless導入編",
                            UnitPrice = 1700m
                        },
                        new
                        {
                            Id = 9,
                            Description = "ノーコードでTODOアプリが作れます。",
                            ImageUrl = "https://raw.githubusercontent.com/nekojoker/sample-contents/main/images/6.png",
                            Title = "猫でもわかるAppgyverTodoアプリを作ろう",
                            UnitPrice = 1800m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
