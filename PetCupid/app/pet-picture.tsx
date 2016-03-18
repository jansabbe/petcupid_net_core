import * as React from 'react';

interface IPetProps {
    imageUrl: string,
    name: string,
    description?: string
}

export class PetPicture extends React.Component<IPetProps,{}> {
    public render() {
        return  <div className="gallery-pet">
                    <img className="profile-picture" src={this.props.imageUrl} />
                    
                    <div className="overlay">
                        <div className="overlay-text">{this.props.name}</div>
                    </div>
                </div>
    }
}