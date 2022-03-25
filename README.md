# Tubes Stima 2 by PenjelajahHatiAyank
> Folder crawler written in C#. Based on the concept of Breadth First Search (BFS) and Depth First Search (DFS) algorithm.


## Table of Contents
* [Introduction](#introduction)
* [General Information](#general-information)
* [Technologies Used](#technologies-used)
* [Features](#features)
* [Overview](#overview)
* [Setup](#setup)
* [Project Status](#project-status)
* [Room for Improvement](#room-for-improvement)
* [Acknowledgements](#acknowledgements)
* [Library](#library)
* [Contact](#contact)


## Introduction
Hello, everyone! Welcome to our GitHub Repository!

This project was created by:
| No. | Name | Student ID |
| :---: | :---: | :---: |
| 1. | Ignasius Ferry Priguna | 13520126 |
| 2. | Nelsen Putra | 13520130 |
| 3. | Daffa Romyz Aufa | 13520162 |


## General Information
![SearchFeature](https://www.digitalcitizen.life/wp-content/uploads/2020/10/explorer_search_10.png)

When we have a desire to find a specific file stored in our computer, it usually takes a long time if we do it manually by checking whether the file exists in certain folder. Not only do we have to open several folders to reach the desired directory, we even by worse can forget where we put the file we are looking for. As a consequence, we have to open various folders one by one until we find the desired file. This is for sure will be very time and energy consuming.

However, we don't need to worry anymore about this problem right now. The reason is, almost all operating systems already provide a file explorer feature that can be used to find the exact file we want. We do it simply by entering a query or keyword in the search box, then the computer will search for all files in a starting directory (up to all of its children) which correspond to the query we entered.

That feature is implemented with a popular technique called folder crawling technique, where the computer engine will start searching for files that match the query, starting from the starting directory to the whole children of starting directory until the first file/all files are found or no file is found. Algorithms that can be chosen to perform the crawl can also vary and each algorithm will have its own techniques and consequences. Therefore, it is important that the computer chooses the right algorithm so that the desired result can be found in a short and effective time.


## Technologies Used
The whole program was written in C# using Visual Studio.


## Features
- [x] Receive a folder query or file name as an input 
- [x] Browse the folders in the directory to get the desired directory/file with 2 options of algorithms that can be choosen by user
- [x] Choose to show only one result or find all files which have the exact same file name as the query input
- [x] Visualize the results of folder search in the form of a tree by giving the description of folders/files that have been checked, folders/files that have entered the queue but has not been checked, and the routes of the folders and files that are the routes of the meeting result
- [x] Display a list of paths of the corresponding leaves search result where the path is required to have a hyperlink to the parent folder of the file
searched, so that file can be directly accessed via browser or file explorer
- [x] Count and display the running time of the algorithm (the searching process)
- [x] **(Bonus)** Display the progress of tree formation by adding node according to current folder/file check take place


## Overview
![Overview](https://drive.google.com/uc?export=view&id=1_hT1eO8VugiLuk7CbM8qe6-UxR1P_8_D)


## Setup
### Installation
- Download and install [Visual Studio](https://visualstudio.microsoft.com/vs/) 
- Install the whole modules and [libraries](#library) used in the source code
- Download the whole folders and files in this repository or do clone the repository

### Compilation 
1. Clone this repository in your own local directory

    `git clone https://github.com/nelsenputra/Tubes2_13520126.git`

2. Open the directory in Visual Studio
    
3. In Solution Explorer, select FolderCrawler.sln
 
4. Click Start


## Project Status
Project is: _complete_

All the specifications were implemented.


## Room for Improvement
- A faster or more efficient algorithm to make the program run quicker
- A better UI/UX to satisfy the users of this application


## Acknowledgements
- This project was based on [Spesifikasi Tugas Besar 2 Stima](https://drive.google.com/file/d/1Enil91-RvdyFESd8eqUBWWyV6OdFU7Hm/view?usp=sharing)
- Thanks to God
- Thanks to Mrs. Masayu Leylia Khodra, Mrs. Nur Ulfa Maulidevi, and Mr. Rinaldi as our lecturers
- Thanks to academic assistants
- This project was created to fulfill our Big Project for IF2211 Algorithm Strategies

## Library
* [MSAGL](https://www.microsoft.com/en-us/research/project/microsoft-automatic-graph-layout/)

## Contact
Created by PenjelajahHatiAyank. 2022 All Rights Reserved.
