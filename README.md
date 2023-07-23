<!-- PROJECT SHIELDS -->
<!--
*** I'm using markdown "reference style" links for readability.
*** Reference links are enclosed in brackets [ ] instead of parentheses ( ).
*** See the bottom of this document for the declaration of the reference variables
*** for contributors-url, forks-url, etc. This is an optional, concise syntax you may use.
*** https://www.markdownguide.org/basic-syntax/#reference-style-links
-->
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]
[![MIT License][license-shield]][license-url]
[![LinkedIn][linkedin-shield]][linkedin-url]



<!-- PROJECT LOGO -->
<br />
<div align="center">
<h3 align="center">Order Tracking System</h3>
 <img align="center" src="https://i.makeagif.com/media/7-23-2023/wrLm5B.gif">
  <p align="center">
    <br />
   Queue Implementation using a Custom Linked List.
    <br />
    <br />
    <a href="https://youtu.be/JnfR4s8A6bI">View Demo</a>
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
      </ul>
    </li>
    <li>
      <a href="#getting-started">Getting Started</a>
      <ul>
        <li><a href="#prerequisites">Prerequisites</a></li>
        <li><a href="#installation">Installation</a></li>
      </ul>
    </li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#roadmap">Roadmap</a></li>
    <li><a href="#contributing">Contributing</a></li>
    <li><a href="#license">License</a></li>
    <li><a href="#contact">Contact</a></li>
    <li><a href="#acknowledgments">Acknowledgments</a></li>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## About The Project

This project was created to show the implementation of the queue data structure using a custom linked list. 
The goal in mind was to create a project that would showcase how a restaurant order tracking system works using FIFO (First In, First Out). 
Reward Members got priority service and skipped to the front of the line. 
Implemented IEnumerable to iterate over a collection of a specified type. 
<p align="right">(<a href="#readme-top">back to top</a>)</p>



### Built With
<p align="left">Windows Forms</p>

[![WindowsForms][WindowsForms.Net]][WindowsForms-url]

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- GETTING STARTED -->
## Getting Started
To get a local copy up and running follow these simple example steps.

### Prerequisites

* npm
  ```sh
  npm install npm@latest -g
  ```

### Installation

1. Clone the repo
   ```sh
   git clone https://github.com/RomainRichards/Order-Tracking-System.git
   ```
2. Open with Microsoft Visual Studio
   
<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- USAGE EXAMPLES -->
## Usage

Use to show how restaurant orders are taken and served. 

![Burger Madness Home](https://github.com/RomainRichards/Order-Tracking-System/assets/96961208/6c946c28-f393-4170-bf8e-4c383762913c)

![Burger Madness Customer Portal](https://github.com/RomainRichards/Order-Tracking-System/assets/96961208/63627daf-e202-4daa-bfd0-14e41f6d3048)

![Burger Madness Orders](https://github.com/RomainRichards/Order-Tracking-System/assets/96961208/f2ec1ce6-859b-465c-8da9-a23c6cbaad05)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- ROADMAP -->
## Roadmap

* Create node class.
    * Add properties and their values and two pointers (next, prev).
    * Next is for the next node in the linked list.
    * Prev is for the previous node in the linked list.
* Create custom linked list class.
    * Add all the methods needed to acomplish what you need.
    * Research yeild return and IEnumerable to fully understand how to traverse the custom linked list.
* Create global data class to access the custom linked list from any user control or form.
    * Important if using mutiple user controls or forms within the project.
* Create three user controls for home, customer portal and orders.
    * Design how you would like. The key was to 'bringToFront()' each user control instead of changing the visibility to navigate each control. 
* Style and design user controls and form.
    * Bring everything together and debug if there are any problems.


See the [open issues](https://github.com/RomainRichards/Order-Tracking-System/issues) for a full list of proposed features (and known issues).

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTRIBUTING -->
## Contributing

Any contributions you make are **greatly appreciated**.

If you have a suggestion that would make this better, please fork the repo and create a pull request. You can also simply open an issue with the tag "enhancement".
Don't forget to give the project a star! Thanks again!

1. Fork the Project
2. Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3. Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the Branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- CONTACT -->
## Contact

YouTube - [YouTube](https://www.youtube.com/@romainrichards7471/)

Project Link: [https://github.com/RomainRichards/Order-Tracking-System](https://github.com/RomainRichards/Order-Tracking-System)

<p align="right">(<a href="#readme-top">back to top</a>)</p>



<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/RomainRichards/Order-Tracking-System.svg?style=for-the-badge
[contributors-url]: https://github.com/RomainRichards/Order-Tracking-System/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/RomainRichards/Order-Tracking-System.svg?style=for-the-badge
[forks-url]: https://github.com/RomainRichards/Order-Tracking-System/network/members
[stars-shield]: https://img.shields.io/github/stars/RomainRichards/Order-Tracking-System.svg?style=for-the-badge
[stars-url]: https://github.com/RomainRichards/Order-Tracking-System/stargazers
[issues-shield]: https://img.shields.io/github/issues/RomainRichards/Order-Tracking-System.svg?style=for-the-badge
[issues-url]: https://github.com/RomainRichards/Order-Tracking-System/issues
[license-shield]: https://img.shields.io/github/license/RomainRichards/Order-Tracking-System.svg?style=for-the-badge
[license-url]: https://github.com/RomainRichards/Order-Tracking-System/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://www.linkedin.com/in/romain-richards/
[WindowsForms.NET]: https://th.bing.com/th/id/OIP.yf4WhyahfDl9PDQ_ONW2_wHaDa?pid=ImgDet&rs=1
[WindowsForms-url]: https://learn.microsoft.com/en-us/dotnet/desktop/winforms/get-started/create-app-visual-studio?view=netdesktop-7.0&source=recommendations
