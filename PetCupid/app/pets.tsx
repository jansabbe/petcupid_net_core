import * as React from 'react';
import {PetPicture} from './pet-picture.tsx';

export interface IPet {
    name: string,
    imageUrl: string
}

interface IPetsProps {
    pets: IPet[]
}

export class PetsGallery extends React.Component<IPetsProps,{}> {

    public render() {
        return <div className="container-fluid">
                    <div className="row">
                        <div className="col-md-9">
                            <div className="gallery">
                                {this.props.pets.map((p) => <PetPicture imageUrl={p.imageUrl} name={p.name} />)}
                            </div>
                        </div>
                        <div className="col-md-3">
                            <div className="gallery-detail">
                                <section className="tiny-dialog">
                                    <h3>Pick &amp; Play</h3>

                                    <p>Like to play and cudle with pets but can't keep one at home?</p>
                                    <ol className="big-numbers">
                                        <li>Pick a cute pet</li>
                                        <li>Setup a date</li>
                                        <li>Go play!</li>
                                    </ol>
                                </section>
                                <section className="tiny-dialog">
                                    <h3>Find your pet</h3>

                                    <form>
                                        <div className="form-group">
                                            <input className="form-control" placeholder="Search" />
                                        </div>
                                        <div className="form-group">
                                            <select className="form-control">
                                                <option value="">All</option>
                                                <option value="cat">Cat</option>
                                                <option value="dog">Dog</option>
                                                <option value="chicken">Chicken</option>
                                            </select>
                                        </div>
                                    </form>
                                </section>

                                <section className="tiny-dialog">
                                    <h3>Bobby</h3>

                                    <p>Bobby loves to fetch balls and chase rabbits. Great with kids.</p>

                                    <div className="dialog-centered">
                                        <button type="button" className="btn btn-primary btn-lg dialog-centered">Setup date</button>
                                    </div>
                                </section>
                            </div>
                        </div>
                    </div>
               </div>;
    }
}