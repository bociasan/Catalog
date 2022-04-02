import React from "react";

class DisplayTableTeachers extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            list: ['']
        }
        this.callApi = this.callApi.bind(this)
        this.callApi();
    }

    callApi() {
        fetch(`https://localhost:44328/api/Teachers`).then(
            (response) => response.json()
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
                    <td>{item.Id}</td>
                    <td>{item.FirstName}</td>
                    <td>{item.LastName}</td>
                    <td>{item.Email}</td>
                    <td>{item.Phone}</td>
                    {/*<td><button className="btn btn-danger">Remove</button></td>*/}
                </tr>
            )
        })
        return (
            <div className="container">
                {this.state.teacher &&
                <h2>Teacher {this.state.teacher.FirstName} {this.state.teacher.LastName} subjects: </h2>}
                <table className="table table-striped table-hover align-middle">
                    <thead>
                    <tr>
                        <th>Id</th>
                        <th>FirstName</th>
                        <th>LastName</th>
                        <th>Email</th>
                        <th>Phone</th>
                        {/*<th></th>*/}
                    </tr>
                    </thead>
                    <tbody>
                    {tb_data}
                    </tbody>
                </table>
            </div>
        )
    }
}

export default DisplayTableTeachers;