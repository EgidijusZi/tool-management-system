import { React, useState, useEffect } from 'react';
import {
  Button,
  Dialog,
  DialogActions,
  DialogContent,
  TextField,
} from '@mui/material';

const BasicForm = ({
  columns,
  selectedRow,
  onRequest,
  open,
  onDialogClose,
}) => {
  const [formInputs, setFormInputs] = useState({});

  useEffect(() => {
    let initialFormState = selectedRow
      ? columns.reduce((accumulator, column) => {
          return { ...accumulator, [column.id]: selectedRow[column.id] };
        }, {})
      : columns.reduce((accumulator, column) => {
          return { ...accumulator, [column.id]: '' };
        }, {});
    setFormInputs(initialFormState);
  }, [selectedRow]);

  const handleChange = (event, id) => {
    setFormInputs({ ...formInputs, [id]: event.target.value });
  };

  const handleButtonClick = (event) => {
    event.preventDefault();
    onRequest(formInputs);
  };

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
                sx={{
                  display: 'flex',
                  direction: 'column',
                  mt: 2,
                  width: '300px',
                }}
                value={formInputs[column.id] || ''}
                onChange={(event) => handleChange(event, column.id)}
              ></TextField>
            );
          })}
        </DialogContent>
        <DialogActions>
          <Button
            onClick={handleButtonClick}
            variant='contained'
            sx={{ mt: 0, mr: 2 }}
          >
            Submit
          </Button>
        </DialogActions>
      </Dialog>
    </>
  );
};

export default BasicForm;
