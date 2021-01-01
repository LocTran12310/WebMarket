
import React, { Component } from 'react';
import axios from 'axios';

export class CreateData extends Component {
    static displayName = CreateData.name;
    constructor(props) {
        super(props);
        this.state= {
            cityId: '',
            cityName: '',
        };
        this.create = this.create.bind(this);
        this.onChange = this.onChange.bind(this);
    };

    create(event) {
        event.preventDefault();
        const data = new FormData(event.target);
        axios.post(`https://localhost:44394/api/TblCities`, data).then(function (res) { console.log(res) });
        
    }

    onChange = (e) => {
        this.setState({ [e.target.name]: e.target.value });
    }
    render() {
        return (
            <div>
                <form onSubmit={this.create}>
                    
                    <div className="form-group">
                        <label className="control-label"></label>
                        <input type="text" className="form-control" name="cityName" />

                    </div>
                    <div className="form-group">
                        <input type="submit" value="Create" className="btn btn-default" />
                    </div>
                </form>
            </div>
        );
    }
}
