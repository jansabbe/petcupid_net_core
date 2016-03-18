import * as React from 'react';
import * as ReactDOM from 'react-dom';
import {PetsGallery, IPet} from './pets.tsx';


let pets : IPet[] = [
    {
        name: "Princess",
        imageUrl: "images/chicken1.jpg"
    },
    {
        name: "MrFuzz",
        imageUrl: "images/cat1.jpg"
    },
    {
        name: "Burt",
        imageUrl: "images/dog1.jpg"
    },
    {
        name: "MissPoes",
        imageUrl: "images/cat2.jpg"
    },
    {
        name: "Lady",
        imageUrl: "images/dog2.jpg"
    },
    {
        name: "Grumpy",
        imageUrl: "images/cat3.jpg"
    },
    {
        name: "Bobby",
        imageUrl: "images/dog3.jpg"
    },
];

ReactDOM.render(<PetsGallery pets={pets} />, document.getElementById("app-container"))
