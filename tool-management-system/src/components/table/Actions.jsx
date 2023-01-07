import DeleteIcon from '@mui/icons-material/Delete';
import EditIcon from '@mui/icons-material/Edit';

export const actions = [
    {
        title: 'Edit',
        icon: <EditIcon />,
    },
    {
        title: 'Delete',
        icon: <DeleteIcon />,
    }
]

export const setActionHandlers = (actions, functionArray) => {
    if (functionArray.length !== actions.length) {
        console.error("Wrong actions handler list length");
        return;
    }
    const newActions = actions.map((action, index) => {
        return ({...action, eventHandler: functionArray[index]})
    });
    return newActions
}
