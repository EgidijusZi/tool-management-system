import { React, useState } from 'react';
import { Button, Dialog, DialogActions, DialogContent, TextField } from '@mui/material';

const CreationForm = ({ columns, onCreate, open, onDialogClose }) => {

  const [formInputs, setFormInputs] = useState(columns.reduce((accumulator, column) => {
    return ({...accumulator, [column.id] : ''});
  }, {}))

  const handleChange = (event, id) => {
    setFormInputs({...formInputs, [id] : event.target.value})
  }

  const handleButtonClick = (event) => {
    event.preventDefault();
    onCreate(formInputs);
  }

  return (
    <>
      <Dialog open={open} onClose={onDialogClose}>
        <DialogContent>
          {columns.map((column) => {
            return (
              <TextField
                key={column.id}
                id={column.id}
                label={column.label}
                variant='outlined'
                sx={{display: 'flex', direction: 'column', mt: 2, width: '300px'}}
                onChange={(event) => handleChange(event, column.id)}
              ></TextField>
            );
          })}
        </DialogContent>
        <DialogActions>
          <Button onClick={handleButtonClick} variant='contained' sx={{ mt: 0, mr: 2 }}>Create</Button>
        </DialogActions>
      </Dialog>
    </>
  );
};

export default CreationForm;
