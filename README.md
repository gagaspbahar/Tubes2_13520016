# Folder Crawler
> Tugas Besar Mata Kuliah IF2211 Strategi Algoritma
> Built by Kelompok 1 - Cool Story

## Table of Contents
* [General Info](#general-information)
* [Features](#features)
* [Technologies Used](#technologies-used)
* [Setup](#setup)
* [Usage](#usage)
* [Panduan Install MSAGL](#panduan-install-msagl)
* [Project Status](#project-status)
* [Acknowledgements](#acknowledgements)
* [Contact](#contact)
<!-- * [License](#license) -->


## General Information

Folder Crawler adalah program untuk menelusuri semua folder - folder yang ada pada direktori untuk menemukan file yang diinginkan. Program ini akan menampilkan hasil pencarian dalam bentuk Graf, Graf dibentuk secara realtime.

## Features
- BFS 
- DFS
- GUI
- Exception Handling
- RealTime Graph Visualization
- Hyperlink 

## Technologies Used
- C# 
- Visual Studio
- MSAGL
- WinForm

## Setup

- Visual Studio (Jika ingin melakukan build sendiri)
- C#
- MSAGL

## Usage

- Program dapat langsung dijalankan dengan file “.exe”-nya ataupun dapat di-build terlebih dahulu di Visual Studio. 
- Untuk menjalankan program, dapat di-run secara langsung melalui file FolderCrawler.exe yang terdapat pada direktori “(ISI NANTI)”.
- Jika ingin melakukan build, buka file solution FolderCrawler.sln pada “(ISI NANTI)” dengan menggunakan Visual Studio dan tekan F5 ataupun CTRL + F5 untuk melakukan build. Hasil dari build tersebut akan langsung muncul dan program dapat langsung digunakan, pastikan sudah melakukan install untuk dependency MSAGL sebelumnya. Panduan install MSAGL : [Panduan Install MSAGL](#panduan-install-msagl) 

Untuk melakukan pencarian file dengan menggunakan FolderCrawler.exe dapat dilakukan dengan cara sebagai berikut :

1. Pilih root folder dengan memencet button “Choose Folder” dan silahkan arahkan kepada folder sesuai yang diinginkan.
2. Ketik nama file yang ingin dicari pada folder yang telah dipilih sebelumnya
3. Pilih metode pencarian file yang diinginkan dengan cara memencet salah satu dari tombol BFS ataupun DFS.
4. Sebagai opsi tambahan untuk mencari semua file yang terdapat pada root folder, dapat memencet box “Find all occurence”.
5. Pencet tombol “Search” jika langkah 1 sampai 4 telah dilakukan. Visualisasi dari pencarian file akan tampil pada label kosong. Waktu algoritma berjalan juga akan muncul beserta hyperlink yang bisa di-klik untuk langsung membuka folder ditemukannya file yang dicari.

## Panduan Install MSAGL

    1. Pastikan projek menggunakan kakas .NET untuk c#
    2. Pada aplikasi Visual Studio, Install NuGet Package untuk MSAGL sesuai dengan yang ada di repo GitHub dengan Package Manager pada menu Tools > NuGet Package Manager > Package Manager Console
    3. Untuk menambah library MSAGL pada projek perlu melakukan install untuk modul - modul MSAGL, terdapat 4 buat modul. Gunakan command berikut pada Package Manager Console untuk menginstall package :
    - Install-Package AutomaticGraphLayout -Version 1.1.11
    - Install-Package AutomaticGraphLayout.Drawing -Version 1.1.11
    - Install-Package AutomaticGraphLayout.WpfGraphControl -Version 1.1.11
    - Install-Package AutomaticGraphLayout.GraphViewerGDI -Version 1.1.11



## Project Status
Project ini sudah  _selesai_ 

## Acknowledgements


## Contact
Created by:
- [@apwic](https://github.com/apwic)
- [@dhikaarta](https://github.com/dhikaarta)
- [@gagaspbahar](https://github.com/gagaspbahar)

<!-- Optional -->
<!-- ## License -->
<!-- This project is open source and available under the [... License](). -->

<!-- You don't have to include all sections - just the one's relevant to your project -->
