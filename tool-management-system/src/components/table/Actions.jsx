import DeleteIcon from '@mui/icons-material/Delete';
import EditIcon from '@mui/icons-material/Edit';

export const actions = [
  {
    title: 'Edit',
    icon: <EditIcon />,
    role: ['Manager', 'Storekeeper'],
  },
  {
    title: 'Delete',
    icon: <DeleteIcon />,
    role: ['Manager', 'Storekeeper'],
  },
];

export const setActionHandlers = (actions, arrayOfHandlers) => {
  if (arrayOfHandlers.length !== actions.length) {
    console.error('Wrong action handlers array length');
    return;
  }
  const newActions = actions.map((action, index) => {
    return { ...action, eventHandler: arrayOfHandlers[index] };
  });
  return newActions;
};
