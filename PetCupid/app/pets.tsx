import * as React from 'react';

export let pets = <div className="container-fluid">
    <div className="row">
        <div className="col-md-9">
            <div className="gallery">
                <div className="gallery-pet">
                    <img className="profile-picture" src="images/chicken1.jpg" />
                    
                    <div className="overlay">
                        <div className="overlay-text">Princess</div>
                    </div>
                </div>
                <div className="gallery-pet">
                    <img className="profile-picture" src="images/cat1.jpg" />

                    <div className="overlay">
                        <div className="overlay-text">MrFuzz</div>
                    </div>
                </div>
                <div className="gallery-pet">
                    <img className="profile-picture" src="images/dog1.jpg" />

                    <div className="overlay">
                        <div className="overlay-text">Burt</div>
                    </div>
                </div>
                <div className="gallery-pet">
                    <img className="profile-picture" src="images/cat2.jpg" />

                    <div className="overlay">
                        <div className="overlay-text">MissPoes</div>
                    </div>
                </div>
                <div className="gallery-pet">
                    <img className="profile-picture" src="images/dog2.jpg" />

                    <div className="overlay">
                        <div className="overlay-text">Lady</div>
                    </div>
                </div>
                <div className="gallery-pet">
                    <img className="profile-picture" src="images/cat3.jpg" />

                    <div className="overlay">
                        <div className="overlay-text">Grumpy</div>
                    </div>
                </div>
                <div className="gallery-pet active">
                    <img className="profile-picture" src="images/dog3.jpg" />

                    <div className="overlay">
                        <div className="overlay-text">Bobby</div>
                    </div>
                </div>

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