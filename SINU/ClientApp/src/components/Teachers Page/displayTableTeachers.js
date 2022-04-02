import React from "react";

class DisplayTableTeachers extends React.Component {
    constructor(props) {
        super(props);
        this.state = {
            list: [''],
            teacher: null,
            id: 2022
        }
        this.id = 2022
        this.callApi = this.callApi.bind(this)
        this.callApi();
    }

    callApi() {
        fetch(`https://localhost:44328/api/Teachers/${this.id}`).then(
            (respone) => respone.json()
        ).then((data) => {
            // console.log(data)
            this.setState({
                teacher: data
            })
            // console.log(this.state.list[0].User.FirstName)
            console.log(this.state.teacher)

            fetch(`https://localhost:44328/api/Teachers/${this.state.teacher.Id}/materials`).then(
                (respone) => respone.json()
            ).then((data) => {
                console.log(data)
                this.setState({
                    list: data
                })
                // console.log(this.state.list[0].User.FirstName)
            })
        })

    }

    render() {

        let tb_data = this.state.list.map((item) => {
            return (
                <tr key={[item.SubjectProfesorId]}>
                    <td>{item.SubjectName}</td>
                    <td>{item.StudyYearName}</td>
                    {/*<td><button className="btn btn-danger">Remove</button></td>*/}
                </tr>
            )
        })
        return (
            <div className="container">
                {this.state.list[0] && <h2>Teacher {this.state.teacher.FirstName} {this.state.teacher.LastName} subjects: </h2>}
                <table className="table table-striped table-hover align-middle">
                    <thead>
                    <tr>
                        <th>Subject</th>
                        <th>StudyYear</th>
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