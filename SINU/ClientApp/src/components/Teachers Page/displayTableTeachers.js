import React from "react";

class DisplayTableTeachers extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            list: [],
            userId: 0,
            firstname: "",
            lastname: ""
        }
        this.userId = 2022
        this.callApi = this.callApi.bind(this)
        this.callApi();
    }

    callApi() {
        // fetch("https://localhost:44328/api/Teachers/"+this.userId+"/materials").then(
        fetch(`https://localhost:44328/api/Teachers/${this.userId}/materials`).then(
            (respone) => respone.json()
        ).then((data) => {
            console.log(data)
            this.setState({
                list: data
            })
            // console.log(this.state.list[0].User.FirstName)
        })
    }

    render() {
        let tb_data = this.state.list.map((item) => {
            return (
                <tr key={[item.Id]}>
                    <td>{item.Subject.Name}</td>
                    <td>{item.StudyYear.Year}</td>
                    {/*<td><button className="btn btn-danger">Remove</button></td>*/}
                </tr>
            )
        })
        return (
            <div className="container">
                {this.state.list[0] && <h2>Teacher {this.state.list[0].User.FirstName} {this.state.list[0].User.LastName} subjects: </h2>}
                <table className="table table-striped table-hover align-middle" >
                    <thead>
                    <tr>
                        <th>Subject</th>
                        <th>StudyYear</th>
                        {/*<th></th>*/}
                    </tr>
                    </thead>
                    <tbody >
                    {tb_data}
                    </tbody>
                </table>
            </div>
        )
    }
}

export default DisplayTableTeachers;